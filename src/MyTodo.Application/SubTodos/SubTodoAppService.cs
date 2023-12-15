using System;
using System.Linq;
using System.Threading.Tasks;
using MyTodo.Permissions;
using MyTodo.SubTodos.Dtos;
using Volo.Abp.Application.Services;

namespace MyTodo.SubTodos;


public class SubTodoAppService : CrudAppService<SubTodo, SubTodoDto, Guid, SubTodoGetListInput, CreateUpdateSubTodoDto, CreateUpdateSubTodoDto>,
    ISubTodoAppService
{
    protected override string GetPolicyName { get; set; } = MyTodoPermissions.SubTodo.Default;
    protected override string GetListPolicyName { get; set; } = MyTodoPermissions.SubTodo.Default;
    protected override string CreatePolicyName { get; set; } = MyTodoPermissions.SubTodo.Create;
    protected override string UpdatePolicyName { get; set; } = MyTodoPermissions.SubTodo.Update;
    protected override string DeletePolicyName { get; set; } = MyTodoPermissions.SubTodo.Delete;

    private readonly ISubTodoRepository _repository;

    public SubTodoAppService(ISubTodoRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<SubTodo>> CreateFilteredQueryAsync(SubTodoGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
            .WhereIf(!input.Description.IsNullOrWhiteSpace(), x => x.Description.Contains(input.Description))
            .WhereIf(input.StatusTodo != null, x => x.StatusTodo == input.StatusTodo)
            .WhereIf(input.TodoId != null, x => x.TodoId == input.TodoId)
            //.WhereIf(input.Todo != null, x => x.Todo == input.Todo)
            ;
    }
}
