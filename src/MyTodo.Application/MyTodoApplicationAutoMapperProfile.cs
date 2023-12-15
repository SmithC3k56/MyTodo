using MyTodo.Todos;
using MyTodo.Todos.Dtos;
using MyTodo.SubTodos;
using MyTodo.SubTodos.Dtos;
using MyTodo.Users;
using MyTodo.Users.Dtos;
using AutoMapper;

namespace MyTodo;

public class MyTodoApplicationAutoMapperProfile : Profile
{
    public MyTodoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Todo, TodoDto>();
        CreateMap<CreateUpdateTodoDto, Todo>(MemberList.Source);
        CreateMap<SubTodo, SubTodoDto>();
        CreateMap<CreateUpdateSubTodoDto, SubTodo>(MemberList.Source);
        CreateMap<AppUser, AppUserDto>();
        CreateMap<CreateUpdateAppUserDto, AppUser>(MemberList.Source);
    }
}
