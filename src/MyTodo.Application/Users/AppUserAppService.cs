using System;
using System.Linq;
using System.Threading.Tasks;
using MyTodo.Permissions;
using MyTodo.Users.Dtos;
using Volo.Abp.Application.Services;

namespace MyTodo.Users;


public class AppUserAppService : CrudAppService<AppUser, AppUserDto, Guid, AppUserGetListInput, CreateUpdateAppUserDto, CreateUpdateAppUserDto>,
    IAppUserAppService
{
    protected override string GetPolicyName { get; set; } = MyTodoPermissions.AppUser.Default;
    protected override string GetListPolicyName { get; set; } = MyTodoPermissions.AppUser.Default;
    protected override string CreatePolicyName { get; set; } = MyTodoPermissions.AppUser.Create;
    protected override string UpdatePolicyName { get; set; } = MyTodoPermissions.AppUser.Update;
    protected override string DeletePolicyName { get; set; } = MyTodoPermissions.AppUser.Delete;

    private readonly IAppUserRepository _repository;

    public AppUserAppService(IAppUserRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<AppUser>> CreateFilteredQueryAsync(AppUserGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.UserName.IsNullOrWhiteSpace(), x => x.UserName.Contains(input.UserName))
            .WhereIf(!input.Email.IsNullOrWhiteSpace(), x => x.Email.Contains(input.Email))
            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
            .WhereIf(!input.Surname.IsNullOrWhiteSpace(), x => x.Surname.Contains(input.Surname))
            .WhereIf(input.IsActive != null, x => x.IsActive == input.IsActive)
            .WhereIf(input.EmailConfirmed != null, x => x.EmailConfirmed == input.EmailConfirmed)
            .WhereIf(!input.PhoneNumber.IsNullOrWhiteSpace(), x => x.PhoneNumber.Contains(input.PhoneNumber))
            .WhereIf(input.PhoneNumberConfirmed != null, x => x.PhoneNumberConfirmed == input.PhoneNumberConfirmed)
            .WhereIf(!input.Bird.IsNullOrWhiteSpace(), x => x.Bird.Contains(input.Bird))
            .WhereIf(input.todos != null, x => x.todos == input.todos)
            ;
    }
}
