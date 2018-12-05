using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.UI.Xaml.Controls;
using Remotion.Linq.Parsing.Structure.NodeTypeProviders;
using SupportTicketSystem.Annotations;

namespace SupportTicketSystem.Model
{
    public class UserLoginCatalog
    {


        //public UserLoginCatalog()
        //{
        //    All = new List<User>();
        //    All.Add(new User("Hasan", "1234"));

        //}

        public List<User> All { get; set; }

        public bool OkUser(string name, string pwd)
        {
            List<User>  matchingUsers = All.Where(u => u.Name == name).ToList();
            if (matchingUsers.Count > 0 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        

        
    }
}