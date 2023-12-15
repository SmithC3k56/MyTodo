using System;
using System.Linq;
using System.Threading.Tasks;
using MyTodo.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MyTodo.SubTodos;

public class SubTodoRepository : EfCoreRepository<MyTodoDbContext, SubTodo, Guid>, ISubTodoRepository
{
    public SubTodoRepository(IDbContextProvider<MyTodoDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<SubTodo>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}