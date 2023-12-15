using MyTodo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTodo.Permissions;

public class MyTodoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyTodoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MyTodoPermissions.MyPermission1, L("Permission:MyPermission1"));

        var todoPermission = myGroup.AddPermission(MyTodoPermissions.Todo.Default, L("Permission:Todo"));
        todoPermission.AddChild(MyTodoPermissions.Todo.Create, L("Permission:Create"));
        todoPermission.AddChild(MyTodoPermissions.Todo.Update, L("Permission:Update"));
        todoPermission.AddChild(MyTodoPermissions.Todo.Delete, L("Permission:Delete"));

        var subTodoPermission = myGroup.AddPermission(MyTodoPermissions.SubTodo.Default, L("Permission:SubTodo"));
        subTodoPermission.AddChild(MyTodoPermissions.SubTodo.Create, L("Permission:Create"));
        subTodoPermission.AddChild(MyTodoPermissions.SubTodo.Update, L("Permission:Update"));
        subTodoPermission.AddChild(MyTodoPermissions.SubTodo.Delete, L("Permission:Delete"));

        var appUserPermission = myGroup.AddPermission(MyTodoPermissions.AppUser.Default, L("Permission:AppUser"));
        appUserPermission.AddChild(MyTodoPermissions.AppUser.Create, L("Permission:Create"));
        appUserPermission.AddChild(MyTodoPermissions.AppUser.Update, L("Permission:Update"));
        appUserPermission.AddChild(MyTodoPermissions.AppUser.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyTodoResource>(name);
    }
}
