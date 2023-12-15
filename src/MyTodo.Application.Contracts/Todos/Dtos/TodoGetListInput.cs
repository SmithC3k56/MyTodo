using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace MyTodo.Todos.Dtos;

[Serializable]
public class TodoGetListInput : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public StatusTodo? StatusTodo { get; set; }

}