namespace MyTodo.Permissions;

public static class MyTodoPermissions
{
    public const string GroupName = "MyTodo";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public class Todo
    {
        public const string Default = GroupName + ".Todo";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
    public class SubTodo
    {
        public const string Default = GroupName + ".SubTodo";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
    public class AppUser
    {
        public const string Default = GroupName + ".AppUser";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
