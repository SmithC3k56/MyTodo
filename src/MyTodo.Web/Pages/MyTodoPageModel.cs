using MyTodo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyTodo.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MyTodoPageModel : AbpPageModel
{
    protected MyTodoPageModel()
    {
        LocalizationResourceType = typeof(MyTodoResource);
    }
}
