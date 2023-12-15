using System;
using Volo.Abp.Domain.Repositories;

namespace MyTodo.SubTodos;

public interface ISubTodoRepository : IRepository<SubTodo, Guid>
{
}
