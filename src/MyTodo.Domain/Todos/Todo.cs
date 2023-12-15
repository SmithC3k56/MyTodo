using MyTodo.SubTodos;
using MyTodo.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyTodo.Todos
{
    public class Todo: FullAuditedAggregateRoot<Guid>
    {
        [StringLength(255)]
        public required string Name { get; set; }
        public string Description { get; set; }
        public StatusTodo StatusTodo { get; set; }
        public List<SubTodo> SubTodos { get; set; }
        //public ICollection<AppUser> Users { get; set; }


        protected Todo()
    {
    }

    

    public Todo(
        Guid id,
        string name,
        string description,
        StatusTodo statusTodo,
        List<SubTodo> subTodos
    ) : base(id)
    {
        Name = name;
        Description = description;
        StatusTodo = statusTodo;
        SubTodos = subTodos;
    }
    }
}
