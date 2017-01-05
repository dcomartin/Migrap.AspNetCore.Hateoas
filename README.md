# Migrap.AspNetCore.Hateoas

HATEOAS (Hypermedia as the Engine of Application State) framework for ASP.NET Core.

Current implementation(s):
- Siren
- JsonApi

```C#
public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        services.AddMvc(options => {
        }).AddSirenOptions(options => {
            options.StateConverters.Add(new ArticleSirenStateConverterProvider());
        });            
    }

    public void Configure(IApplicationBuilder app) {
        app.Use((context, next) => {
            if(context.Request.Path.StartsWithSegments("/ping")) {
                return context.Response.WriteAsync("pong");
            }
            return next();
        });

        app.UseMvc();
    }
}

[Route("[controller]")]
public class ArticlesController : Controller {
    [HttpGet()]
    public IEnumerable<Article> Get() {
        return new List<Article> {
            new Article {
                Id ="1",
                Title = "JSON API paints my bikeshed!",
                Body = "The shortest article. Ever.",
                Created =1432306588,
                Updated =1432306589
            },
            new Article {
                Id ="2",
                Title = "JSON API paints my homework!",
                Body = "The shortest article. Ever... again",
                Created =1432306588,
                Updated =1432306589
            }
        };
    }
}

public class ArticleSirenStateConverterProvider : IStateConverterProvider {
    public IStateConverter CreateConverter(StateConverterProviderContext context) {
        if(context == null) {
            throw new ArgumentNullException(nameof(context));
        }

        if(typeof(Article).IsAssignableFrom(context.ObjectType) || typeof(IEnumerable<Article>).IsAssignableFrom(context.ObjectType)) {
            return new ArticleSirenStateConverter();
        }

        return null;
    }
}

public class ArticleSirenStateConverter : IStateConverter {
    public Task<object> ConvertAsync(StateConverterContext context) {
        var articles = (context.Object as IEnumerable<Article>);

        var path = context.HttpContext.Request.GetDisplayUrl();

        var properties = new {
            count = articles.Count()
        };
            
        var document = new Migrap.AspNetCore.Hateoas.Siren.Core.Document {
            Class = new Class { "article", "collection" },
            Properties = properties,
            Href = path,
        };

        var entities = articles.Select(a => {
            return new Entity {
                Class = new Class { "article" },
                Properties = a,
                Href = $"{path}/{a.Id}",
            };
        });

        document.Entities.Add(entities);

        return Task.FromResult<object>(document);
    }
}    

public class Article {
    public Article() {
    }

    public Article(string id, string title, string body, long created, long updated) {
        Id = id;
        Title = title;
        Body = body;
        Created = created;
        Updated = updated;
    }

    public string Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public long Created { get; set; }
    public long Updated { get; set; }
}
```