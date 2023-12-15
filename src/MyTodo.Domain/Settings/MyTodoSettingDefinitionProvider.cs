using Volo.Abp.Settings;

namespace MyTodo.Settings;

public class MyTodoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyTodoSettings.MySetting1));
    }
}
