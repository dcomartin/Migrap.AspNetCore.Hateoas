using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Migrap.AspNetCore.Hateoas;
using Migrap.AspNetCore.Hateoas.Siren;
using Migrap.AspNetCore.Hateoas.Siren.Core;

namespace Sandbox {
    public class Startup {
        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc(options => {
                options.OutputFormatters.Clear();
                options.OutputFormatters.Add(new SirenOutputFormatter());
            }).AddSiren(options => {
                options.Converters.Add(new ArticleStateConverterProvider());
            });
        }

        public void Configure(IApplicationBuilder app) {
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

    public class ArticleStateConverterProvider : IStateConverterProvider {
        public IStateConverter CreateConverter(StateConverterProviderContext context) {
            if(context == null) {
                throw new ArgumentNullException(nameof(context));
            }

            if(typeof(Article).IsAssignableFrom(context.ObjectType) || typeof(IEnumerable<Article>).IsAssignableFrom(context.ObjectType)) {
                return new ArticleDocumentConverter();
            }

            return null;
        }
    }

    public class ArticleDocumentConverter : IStateConverter {
        public Task<object> ConvertAsync(StateConverterContext context) {
            var articles = (context.Object as IEnumerable<Article>);

            var path = context.HttpContext.Request.GetDisplayUrl();

            var properties = new {
                count = articles.Count()
            };

            var document = new Document {
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
}