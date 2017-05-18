using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Migrap.AspNetCore.Hateoas.Siren.Core;

namespace Migrap.AspNetCore.Hateoas.Demo
{
    public class TodoSirenStateConverterProvider : IStateConverterProvider
    {
        public IStateConverter CreateConverter(StateConverterProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (typeof(TodoModel).IsAssignableFrom(context.ObjectType))
            {
                return new TodoConverter();
            }

            if (typeof(IEnumerable<TodoModel>).IsAssignableFrom(context.ObjectType))
            {
                return new TodoCollectionConverter();
            }

            return null;
        }
    }

    public class TodoConverter : IStateConverter
    {
        public Task<object> ConvertAsync(StateConverterContext context)
        {
            var urlHelper = context.HttpContext.RequestServices.GetRequiredService<IUrlHelper>();

            var todo = context.Object as TodoModel;

            var actions = new List<Siren.Core.Action>();
            actions.Add(new Siren.Core.Action
                {
                    Name = "delete",
                    Title = "Delete Todo",
                    Method = "DELETE",
                    Href = urlHelper.Action("Delete", "Todo"),
                });

            if (todo.IsCompleted == false)
            {
                actions.Add(
                    new Siren.Core.Action
                    {
                        Name = "complete",
                        Title = "Complete Todo",
                        Method = "PUT",
                        Href = urlHelper.Action("Complete", "Todo"),
                    });
            }


            var document = new Document
            {
                Class = new Class { "todo" },
                Properties = todo,
                Href = urlHelper.Action("Get", "Todo"),
                Actions = new Actions(actions)
            };
            
            return Task.FromResult<object>(document);            
        }
    }

    public class TodoCollectionConverter : IStateConverter
    {
        public Task<object> ConvertAsync(StateConverterContext context)
        {
            var todos = (context.Object as IEnumerable<TodoModel>);
            var path = context.HttpContext.Request.GetDisplayUrl();

            var properties = new
            {
                count = todos.Count()
            };

            var document = new Document
            {
                Class = new Class {"todo", "collection"},
                Properties = properties,
                Href = path,
            };

            var entities = todos.Select(a => new Entity
            {
                Class = new Class {"todo"},
                Properties = a,
                Href = $"{path}/{a.TodoId}",
            });

            document.Entities.Add(entities);

            return Task.FromResult<object>(document);
        }
    }
}
