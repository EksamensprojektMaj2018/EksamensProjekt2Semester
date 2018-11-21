using System;
using System.Collections.Generic;

namespace SupportTicketSystem
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public string Company { get; set; }

        public Role RoleNavigation { get; set; }
    }
}
