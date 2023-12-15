using System.Threading.Tasks;
using MyTodo.Permissions;
using MyTodo.Localization;
using MyTodo.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace MyTodo.Web.Menus;

public class MyTodoMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task<Task> ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<MyTodoResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                MyTodoMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
        if (await context.IsGrantedAsync(MyTodoPermissions.Todo.Default))
        {
            context.Menu.GetAdministration().AddItem(
                new ApplicationMenuItem(MyTodoMenus.Todo, l["Menu:Todo"], "/Todos/Todo")
            );
        }
        if (await context.IsGrantedAsync(MyTodoPermissions.SubTodo.Default))
        {
            context.Menu.GetAdministration().AddItem(
                new ApplicationMenuItem(MyTodoMenus.SubTodo, l["Menu:SubTodo"], "/SubTodos/SubTodo")
            );
        }
        if (await context.IsGrantedAsync(MyTodoPermissions.AppUser.Default))
        {
            context.Menu.GetAdministration().AddItem(
                new ApplicationMenuItem(MyTodoMenus.AppUser, l["Menu:AppUser"], "/Users/AppUser")
            );
        }
        return Task.CompletedTask;
        
    }
}
