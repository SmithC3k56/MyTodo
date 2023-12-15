using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using System.Collections.Generic;
using static MyTodo.Permissions.MyTodoPermissions;

namespace MyTodo.Web.Pages.Users.AppUser;

public class IndexModel : MyTodoPageModel
{
    public AppUserFilterInput AppUserFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class AppUserFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUserUserName")]
    public string? UserName { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUserEmail")]
    public string? Email { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUserName")]
    public string? Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUserSurname")]
    public string? Surname { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUserIsActive")]
    public bool? IsActive { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUserEmailConfirmed")]
    public bool? EmailConfirmed { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUserPhoneNumber")]
    public string? PhoneNumber { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUserPhoneNumberConfirmed")]
    public bool? PhoneNumberConfirmed { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUserBird")]
    public string? Bird { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AppUsertodos")]
    public ICollection<Todo>? todos { get; set; }
}
