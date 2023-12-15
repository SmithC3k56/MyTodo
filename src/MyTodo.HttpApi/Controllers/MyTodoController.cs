using MyTodo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTodo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyTodoController : AbpControllerBase
{
    protected MyTodoController()
    {
        LocalizationResource = typeof(MyTodoResource);
    }
}
