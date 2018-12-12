using System.Collections.Generic;
using SupportTicketSystem.Data.Base;

namespace SupportTicketSystem
{
    public partial class Role : DomainClassBase
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
