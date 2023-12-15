using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyTodo.SubTodos;

public static class SubTodoEfCoreQueryableExtensions
{
    public static IQueryable<SubTodo> IncludeDetails(this IQueryable<SubTodo> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}
