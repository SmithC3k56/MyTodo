using System;
using System.Threading.Tasks;
using MyTodo.Users;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MyTodo.EntityFrameworkCore.Users;

public class AppUserRepositoryTests : MyTodoEntityFrameworkCoreTestBase
{
    private readonly IAppUserRepository _appUserRepository;

    public AppUserRepositoryTests()
    {
        _appUserRepository = GetRequiredService<IAppUserRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
