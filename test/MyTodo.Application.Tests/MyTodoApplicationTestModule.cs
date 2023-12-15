using Volo.Abp.Modularity;

namespace MyTodo;

[DependsOn(
    typeof(MyTodoApplicationModule),
    typeof(MyTodoDomainTestModule)
    )]
public class MyTodoApplicationTestModule : AbpModule
{

}
