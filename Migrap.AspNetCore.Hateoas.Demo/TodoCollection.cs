using System;
using System.Collections.Generic;

namespace Migrap.AspNetCore.Hateoas.Demo
{
    public class TodoCollection : List<TodoModel>
    {
        public TodoCollection()
        {
            Add(new TodoModel(Guid.NewGuid(), "Write a blog post about Siren"));
        }   
    }
}
