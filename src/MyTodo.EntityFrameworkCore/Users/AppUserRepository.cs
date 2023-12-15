using System;
using System.Linq;
using System.Threading.Tasks;
using MyTodo.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MyTodo.Users;

public class AppUserRepository : EfCoreRepository<MyTodoDbContext, AppUser, Guid>, IAppUserRepository
{
    public AppUserRepository(IDbContextProvider<MyTodoDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<AppUser>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}