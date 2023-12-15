using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MyTodo.Pages;

public class Index_Tests : MyTodoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
