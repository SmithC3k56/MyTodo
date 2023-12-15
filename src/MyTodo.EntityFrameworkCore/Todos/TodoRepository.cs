using System;
using System.Linq;
using System.Threading.Tasks;
using MyTodo.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MyTodo.Todos;

public class TodoRepository : EfCoreRepository<MyTodoDbContext, Todo, Guid>, ITodoRepository
{
    public TodoRepository(IDbContextProvider<MyTodoDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Todo>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}