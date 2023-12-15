using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTodo.Todos;
using MyTodo.Todos.Dtos;
using MyTodo.Web.Pages.Todos.Todo.ViewModels;

namespace MyTodo.Web.Pages.Todos.Todo;

public class CreateModalModel : MyTodoPageModel
{
    [BindProperty]
    public CreateEditTodoViewModel ViewModel { get; set; }

    private readonly ITodoAppService _service;

    public CreateModalModel(ITodoAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditTodoViewModel, CreateUpdateTodoDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}