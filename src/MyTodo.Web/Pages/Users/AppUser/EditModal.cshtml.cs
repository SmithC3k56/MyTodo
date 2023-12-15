using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTodo.Users;
using MyTodo.Users.Dtos;
using MyTodo.Web.Pages.Users.AppUser.ViewModels;

namespace MyTodo.Web.Pages.Users.AppUser;

public class EditModalModel : MyTodoPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditAppUserViewModel ViewModel { get; set; }

    private readonly IAppUserAppService _service;

    public EditModalModel(IAppUserAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<AppUserDto, CreateEditAppUserViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditAppUserViewModel, CreateUpdateAppUserDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}