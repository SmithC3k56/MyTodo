using System;
using Volo.Abp.Domain.Repositories;

namespace MyTodo.Users;

public interface IAppUserRepository : IRepository<AppUser, Guid>
{
}
