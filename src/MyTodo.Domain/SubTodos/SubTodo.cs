using MyTodo.Todos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyTodo.SubTodos
{
    public class SubTodo : FullAuditedAggregateRoot<Guid>
    {
        [StringLength(255)]
        public required string Name { get; set; }
        public string Description { get; set; }
        public StatusTodo StatusTodo { get; set; } = new StatusTodo();
        
        // Foreign key property
        public Guid TodoId { get; set; }
        
        [ForeignKey("TodoId")]
        public Todo Todo { get; set; }

    protected SubTodo()
    {
    }

 

    public SubTodo(
        Guid id,
        string name,
        string description,
        StatusTodo statusTodo,
        Guid todoId,
        Todo todo
    ) : base(id)
    {
        Name = name;
        Description = description;
        StatusTodo = statusTodo;
        TodoId = todoId;
        Todo = todo;
    }
    }
}
