using System;
using System.Collections.Generic;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;
using static MyTodo.Permissions.MyTodoPermissions;

namespace MyTodo.Users.Dtos;

[Serializable]
public class AppUserGetListInput : PagedAndSortedResultRequestDto
{
    public string? UserName { get; set; }

    public string? Email { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public bool? IsActive { get; set; }

    public bool? EmailConfirmed { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? PhoneNumberConfirmed { get; set; }

    public string? Bird { get; set; }

    public ICollection<Todo>? todos { get; set; }
}