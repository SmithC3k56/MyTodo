using System;
using MyTodo.Users.Dtos;
using Volo.Abp.Application.Services;

namespace MyTodo.Users;


public interface IAppUserAppService :
    ICrudAppService< 
        AppUserDto, 
        Guid, 
        AppUserGetListInput,
        CreateUpdateAppUserDto,
        CreateUpdateAppUserDto>
{

}