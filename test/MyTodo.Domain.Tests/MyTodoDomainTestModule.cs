using MyTodo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTodo;

[DependsOn(
    typeof(MyTodoEntityFrameworkCoreTestModule)
    )]
public class MyTodoDomainTestModule : AbpModule
{

}
