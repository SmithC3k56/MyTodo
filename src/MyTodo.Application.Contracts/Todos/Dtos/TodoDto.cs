using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using static MyTodo.Permissions.MyTodoPermissions;

namespace MyTodo.Todos.Dtos;

[Serializable]
public class TodoDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string Description { get; set; }

    public StatusTodo StatusTodo { get; set; }

    public List<SubTodo> SubTodos { get; set; }
}