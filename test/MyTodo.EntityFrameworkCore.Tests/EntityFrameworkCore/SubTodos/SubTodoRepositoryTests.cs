using System;
using System.Threading.Tasks;
using MyTodo.SubTodos;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MyTodo.EntityFrameworkCore.SubTodos;

public class SubTodoRepositoryTests : MyTodoEntityFrameworkCoreTestBase
{
    private readonly ISubTodoRepository _subTodoRepository;

    public SubTodoRepositoryTests()
    {
        _subTodoRepository = GetRequiredService<ISubTodoRepository>();
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
