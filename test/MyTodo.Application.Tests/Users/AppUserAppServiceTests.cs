using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MyTodo.Users;

public class AppUserAppServiceTests : MyTodoApplicationTestBase
{
    private readonly IAppUserAppService _appUserAppService;

    public AppUserAppServiceTests()
    {
        _appUserAppService = GetRequiredService<IAppUserAppService>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        // Arrange

        // Act

        // Assert
    }
    */
}

