using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTodo.Todos;
using MyTodo.Todos.Dtos;
using MyTodo.Web.Pages.Todos.Todo.ViewModels;

namespace MyTodo.Web.Pages.Todos.Todo;

public class EditModalModel : MyTodoPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditTodoViewModel ViewModel { get; set; }

    private readonly ITodoAppService _service;

    public EditModalModel(ITodoAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<TodoDto, CreateEditTodoViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditTodoViewModel, CreateUpdateTodoDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}