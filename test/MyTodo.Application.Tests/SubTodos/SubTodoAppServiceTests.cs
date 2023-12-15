using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MyTodo.SubTodos;

public class SubTodoAppServiceTests : MyTodoApplicationTestBase
{
    private readonly ISubTodoAppService _subTodoAppService;

    public SubTodoAppServiceTests()
    {
        _subTodoAppService = GetRequiredService<ISubTodoAppService>();
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

