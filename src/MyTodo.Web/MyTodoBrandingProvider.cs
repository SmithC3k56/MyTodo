using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MyTodo.Web;

[Dependency(ReplaceServices = true)]
public class MyTodoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyTodo";
}
