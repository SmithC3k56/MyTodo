using System;
using System.Threading.Tasks;
using MyTodo.Todos;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MyTodo.EntityFrameworkCore.Todos;

public class TodoRepositoryTests : MyTodoEntityFrameworkCoreTestBase
{
    private readonly ITodoRepository _todoRepository;

    public TodoRepositoryTests()
    {
        _todoRepository = GetRequiredService<ITodoRepository>();
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
