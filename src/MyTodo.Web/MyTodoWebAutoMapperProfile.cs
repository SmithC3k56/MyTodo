using MyTodo.Todos.Dtos;
using MyTodo.Web.Pages.Todos.Todo.ViewModels;
using MyTodo.SubTodos.Dtos;
using MyTodo.Web.Pages.SubTodos.SubTodo.ViewModels;
using MyTodo.Users.Dtos;
using MyTodo.Web.Pages.Users.AppUser.ViewModels;
using AutoMapper;

namespace MyTodo.Web;

public class MyTodoWebAutoMapperProfile : Profile
{
    public MyTodoWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<TodoDto, CreateEditTodoViewModel>();
        CreateMap<CreateEditTodoViewModel, CreateUpdateTodoDto>();
        CreateMap<SubTodoDto, CreateEditSubTodoViewModel>();
        CreateMap<CreateEditSubTodoViewModel, CreateUpdateSubTodoDto>();
        CreateMap<AppUserDto, CreateEditAppUserViewModel>();
        CreateMap<CreateEditAppUserViewModel, CreateUpdateAppUserDto>();
    }
}
