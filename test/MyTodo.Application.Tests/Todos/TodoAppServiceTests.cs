using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MyTodo.Todos;

public class TodoAppServiceTests : MyTodoApplicationTestBase
{
    private readonly ITodoAppService _todoAppService;

    public TodoAppServiceTests()
    {
        _todoAppService = GetRequiredService<ITodoAppService>();
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

