using System.Threading.Tasks;

namespace MyTodo.Data;

public interface IMyTodoDbSchemaMigrator
{
    Task MigrateAsync();
}
