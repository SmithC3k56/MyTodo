using System;
using MyTodo.Todos.Dtos;
using Volo.Abp.Application.Services;

namespace MyTodo.Todos;


public interface ITodoAppService :
    ICrudAppService< 
        TodoDto, 
        Guid, 
        TodoGetListInput,
        CreateUpdateTodoDto,
        CreateUpdateTodoDto>
{

}