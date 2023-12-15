using System;
using Volo.Abp.Domain.Repositories;

namespace MyTodo.Todos;

public interface ITodoRepository : IRepository<Todo, Guid>
{
}
