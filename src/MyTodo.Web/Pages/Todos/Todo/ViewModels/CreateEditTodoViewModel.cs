using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static MyTodo.Permissions.MyTodoPermissions;

namespace MyTodo.Web.Pages.Todos.Todo.ViewModels;

public class CreateEditTodoViewModel
{
    [Display(Name = "TodoName")]
    public string Name { get; set; }

    [Display(Name = "TodoDescription")]
    public string Description { get; set; }

    [Display(Name = "TodoStatusTodo")]
    public StatusTodo StatusTodo { get; set; }

    //[Display(Name = "TodoSubTodos")]
    //public List<SubTodo> SubTodos { get; set; }
}
