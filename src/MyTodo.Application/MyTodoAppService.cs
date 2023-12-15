using System;
using System.Collections.Generic;
using System.Text;
using MyTodo.Localization;
using Volo.Abp.Application.Services;

namespace MyTodo;

/* Inherit your application services from this class.
 */
public abstract class MyTodoAppService : ApplicationService
{
    protected MyTodoAppService()
    {
        LocalizationResource = typeof(MyTodoResource);
    }
}
