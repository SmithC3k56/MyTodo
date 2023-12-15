using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTodo.SubTodos;
using MyTodo.SubTodos.Dtos;
using MyTodo.Web.Pages.SubTodos.SubTodo.ViewModels;

namespace MyTodo.Web.Pages.SubTodos.SubTodo;

public class EditModalModel : MyTodoPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditSubTodoViewModel ViewModel { get; set; }

    private readonly ISubTodoAppService _service;

    public EditModalModel(ISubTodoAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<SubTodoDto, CreateEditSubTodoViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditSubTodoViewModel, CreateUpdateSubTodoDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}