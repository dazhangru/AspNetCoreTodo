using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now
            };
            var item2 = new TodoItem { Title = "Build awesome apps", DueAt = DateTimeOffset.Now };
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
