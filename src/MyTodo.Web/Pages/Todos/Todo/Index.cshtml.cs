using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace MyTodo.Web.Pages.Todos.Todo;

public class IndexModel : MyTodoPageModel
{
    public TodoFilterInput TodoFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class TodoFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TodoName")]
    public string? Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TodoDescription")]
    public string? Description { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "TodoStatusTodo")]
    public StatusTodo? StatusTodo { get; set; }

}
