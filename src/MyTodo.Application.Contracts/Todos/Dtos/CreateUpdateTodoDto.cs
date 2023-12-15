using System;
using System.Collections.Generic;
using static MyTodo.Permissions.MyTodoPermissions;

namespace MyTodo.Todos.Dtos;

[Serializable]
public class CreateUpdateTodoDto
{
    public string Name { get; set; }

    public string Description { get; set; }

    public StatusTodo StatusTodo { get; set; }
}