using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SetApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class TodoController : ControllerBase
    //{
    //    private readonly TodoContext _context;
    //    public TodoController(TodoContext context)
    //    {
    //        _context = context;
    //        if (_context.TodoItems.Count() == 0)
    //        {
    //            _context.TodoItems.Add(new TodoItem { Name = "Item1" }); _context.SaveChanges();
    //        }
    //    }


    //    [HttpGet]
    //    public async Task<ActionResult<List<TodoItem>>>GetAll()
    //    {
    //        return  _context.TodoItems.ToList();
    //    }

    //    [HttpGet("{id}", Name = "GetTodo")]
    //    public async Task <ActionResult<TodoItem>> GetById(long id)
    //    {
    //        var item = _context.TodoItems.Find(id);
    //        if (item == null)
    //        {
    //            return NotFound();
    //        }
    //        return item;
    //    }

    //    [HttpPost]
    //    public async Task<ActionResult<TodoItem>> CreateTodoItem(TodoItem todoItemV)
    //    {
    //        var todoItem = new TodoItem
    //        {
    //            IsComplete = todoItemV.IsComplete,
    //        };

    //        _context.TodoItems.Add(todoItem);
    //        await _context.SaveChangesAsync();

    //        return todoItem;
    //    }
    //}
}

