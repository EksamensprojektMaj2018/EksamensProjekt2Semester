using System.Collections.Generic;

namespace SupportTicketSystem
{
    public partial class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public string Company { get; set; }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public Role RoleNavigation { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
