using MyTodo.Todos;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyTodo.Web.Pages.SubTodos.SubTodo.ViewModels;

public class CreateEditSubTodoViewModel
{
    [Display(Name = "SubTodoName")]
    public string Name { get; set; }

    [Display(Name = "SubTodoDescription")]
    public string Description { get; set; }

    [Display(Name = "SubTodoStatusTodo")]
    public StatusTodo StatusTodo { get; set; }

    [Display(Name = "SubTodoTodoId")]
    public Guid TodoId { get; set; }

    [Display(Name = "SubTodoTodo")]
    public Todo Todo { get; set; }
}
