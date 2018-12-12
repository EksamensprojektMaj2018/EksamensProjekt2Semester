using System.Collections.Generic;
using System.Linq;

namespace SupportTicketSystem.Model
{
    public class UserLoginCatalog
    {


        public UserLoginCatalog()
        {
            All = new List<User>();
            All.Add(new User("Hasan", "1234"));

        }

        public List<User> All { get; set; }

        public bool OkUser(string name, string pwd)
        {
            List<User> matchingUsers = All.Where(u => u.Name == name && u.Password == pwd).ToList();

            return (matchingUsers.Count > 0);


        }
    }
}