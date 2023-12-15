using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static MyTodo.Permissions.MyTodoPermissions;

namespace MyTodo.Web.Pages.Users.AppUser.ViewModels;

public class CreateEditAppUserViewModel
{
    [Display(Name = "AppUserUserName")]
    public string UserName { get; set; }

    [Display(Name = "AppUserEmail")]
    public string Email { get; set; }

    [Display(Name = "AppUserName")]
    public string Name { get; set; }

    [Display(Name = "AppUserSurname")]
    public string Surname { get; set; }

    [Display(Name = "AppUserIsActive")]
    public bool IsActive { get; set; }

    [Display(Name = "AppUserEmailConfirmed")]
    public bool EmailConfirmed { get; set; }

    [Display(Name = "AppUserPhoneNumber")]
    public string PhoneNumber { get; set; }

    [Display(Name = "AppUserPhoneNumberConfirmed")]
    public bool PhoneNumberConfirmed { get; set; }

    [Display(Name = "AppUserBird")]
    public string Bird { get; set; }

    [Display(Name = "AppUsertodos")]
    public ICollection<Todo> todos { get; set; }
}
