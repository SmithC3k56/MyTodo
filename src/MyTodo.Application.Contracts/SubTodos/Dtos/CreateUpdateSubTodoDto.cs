using System;
using static MyTodo.Permissions.MyTodoPermissions;

namespace MyTodo.SubTodos.Dtos;

[Serializable]
public class CreateUpdateSubTodoDto
{
    public string Name { get; set; }

    public string Description { get; set; }

    public StatusTodo StatusTodo { get; set; }

    public Guid TodoId { get; set; }

    public Todo Todo { get; set; }
}