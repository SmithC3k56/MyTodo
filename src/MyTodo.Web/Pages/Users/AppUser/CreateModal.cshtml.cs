using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTodo.Users;
using MyTodo.Users.Dtos;
using MyTodo.Web.Pages.Users.AppUser.ViewModels;

namespace MyTodo.Web.Pages.Users.AppUser;

public class CreateModalModel : MyTodoPageModel
{
    [BindProperty]
    public CreateEditAppUserViewModel ViewModel { get; set; }

    private readonly IAppUserAppService _service;

    public CreateModalModel(IAppUserAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditAppUserViewModel, CreateUpdateAppUserDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}