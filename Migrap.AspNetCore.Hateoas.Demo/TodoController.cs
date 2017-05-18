using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Migrap.AspNetCore.Hateoas.Demo
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly TodoCollection _db;

        public TodoController(TodoCollection db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<TodoModel> Get()
        {
            return _db;
        }

        [HttpGet("{id}")]
        public TodoModel Get(Guid id)
        {
            return _db.Single(x => x.TodoId == id);
        }

        [HttpPost]
        public void Post([FromBody]TodoModel value)
        {
            _db.Add(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var todo = _db.SingleOrDefault(x => x.TodoId == id);
            if (todo == null) return NotFound();

            _db.Remove(todo);

            return new NoContentResult();
        }

        [HttpPut("{id}/complete")]
        public TodoModel Complete(Guid id)
        {
            var todo = _db.SingleOrDefault(x => x.TodoId == id);
            if (todo == null) return null;

            todo.IsCompleted = true;

            return todo;
        }
    }
}
