using System;
using MyTodo.SubTodos.Dtos;
using Volo.Abp.Application.Services;

namespace MyTodo.SubTodos;


public interface ISubTodoAppService :
    ICrudAppService< 
        SubTodoDto, 
        Guid, 
        SubTodoGetListInput,
        CreateUpdateSubTodoDto,
        CreateUpdateSubTodoDto>
{

}