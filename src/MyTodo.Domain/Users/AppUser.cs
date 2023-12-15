using MyTodo.Todos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace MyTodo.Users
{
    public class AppUser : FullAuditedAggregateRoot<Guid>, IUser
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public bool IsActive { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }
        

        public Guid? TenantId { get; set; }

        #region custom
        public string Bird { get; set; }
        public ICollection<Todo> todos { get; set; }
        #endregion




    protected AppUser()
    {
    }

    public AppUser(
        Guid id,
        string userName,
        string email,
        string name,
        string surname,
        bool isActive,
        bool emailConfirmed,
        string phoneNumber,
        bool phoneNumberConfirmed,
        Guid? tenantId,
        string bird,
        ICollection<Todo> todos
    ) : base(id)
    {
        UserName = userName;
        Email = email;
        Name = name;
        Surname = surname;
        IsActive = isActive;
        EmailConfirmed = emailConfirmed;
        PhoneNumber = phoneNumber;
        PhoneNumberConfirmed = phoneNumberConfirmed;
        TenantId = tenantId;
        Bird = bird;
        todos = todos;
    }
    }
}
