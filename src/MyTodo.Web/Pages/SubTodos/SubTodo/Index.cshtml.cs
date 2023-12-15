using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using static MyTodo.Permissions.MyTodoPermissions;

namespace MyTodo.Web.Pages.SubTodos.SubTodo;

public class IndexModel : MyTodoPageModel
{
    public SubTodoFilterInput SubTodoFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class SubTodoFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "SubTodoName")]
    public string? Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "SubTodoDescription")]
    public string? Description { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "SubTodoStatusTodo")]
    public StatusTodo? StatusTodo { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "SubTodoTodoId")]
    public Guid? TodoId { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "SubTodoTodo")]
    public Todo? Todo { get; set; }
}
