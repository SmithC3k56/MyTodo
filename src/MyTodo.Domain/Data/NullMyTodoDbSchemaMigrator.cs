using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyTodo.Data;

/* This is used if database provider does't define
 * IMyTodoDbSchemaMigrator implementation.
 */
public class NullMyTodoDbSchemaMigrator : IMyTodoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
