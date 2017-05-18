using System;

namespace Migrap.AspNetCore.Hateoas.Demo
{
    public class TodoModel
    {
        public Guid TodoId { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public TodoModel(Guid todoId, string title)
        {
            TodoId = todoId;
            Title = title;
        }
    }
}
