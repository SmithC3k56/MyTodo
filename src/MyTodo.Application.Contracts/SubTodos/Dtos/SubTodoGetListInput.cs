using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;
using static MyTodo.Permissions.MyTodoPermissions;

namespace MyTodo.SubTodos.Dtos;

[Serializable]
public class SubTodoGetListInput : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public StatusTodo? StatusTodo { get; set; }

    public Guid? TodoId { get; set; }

    public Todo? Todo { get; set; }
}