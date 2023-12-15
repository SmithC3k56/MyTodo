using System;
using System.Linq;
using System.Threading.Tasks;
using MyTodo.Permissions;
using MyTodo.Todos.Dtos;
using Volo.Abp.Application.Services;

namespace MyTodo.Todos;


public class TodoAppService : CrudAppService<Todo, TodoDto, Guid, TodoGetListInput, CreateUpdateTodoDto, CreateUpdateTodoDto>,
    ITodoAppService
{
    protected override string GetPolicyName { get; set; } = MyTodoPermissions.Todo.Default;
    protected override string GetListPolicyName { get; set; } = MyTodoPermissions.Todo.Default;
    protected override string CreatePolicyName { get; set; } = MyTodoPermissions.Todo.Create;
    protected override string UpdatePolicyName { get; set; } = MyTodoPermissions.Todo.Update;
    protected override string DeletePolicyName { get; set; } = MyTodoPermissions.Todo.Delete;

    private readonly ITodoRepository _repository;

    public TodoAppService(ITodoRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Todo>> CreateFilteredQueryAsync(TodoGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
            .WhereIf(!input.Description.IsNullOrWhiteSpace(), x => x.Description.Contains(input.Description))
            .WhereIf(input.StatusTodo != null, x => x.StatusTodo == input.StatusTodo)
            ;
    }
}
