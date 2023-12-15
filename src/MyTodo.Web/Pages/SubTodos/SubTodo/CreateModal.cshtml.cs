using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTodo.SubTodos;
using MyTodo.SubTodos.Dtos;
using MyTodo.Web.Pages.SubTodos.SubTodo.ViewModels;

namespace MyTodo.Web.Pages.SubTodos.SubTodo;

public class CreateModalModel : MyTodoPageModel
{
    [BindProperty]
    public CreateEditSubTodoViewModel ViewModel { get; set; }

    private readonly ISubTodoAppService _service;

    public CreateModalModel(ISubTodoAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditSubTodoViewModel, CreateUpdateSubTodoDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}