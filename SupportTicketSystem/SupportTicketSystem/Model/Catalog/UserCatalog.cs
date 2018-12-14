using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Model.Base;

namespace SupportTicketSystem.Model.Catalog
{
	public class UserCatalog : CatalogAppBase<User>
	{
	    public override List<User> BuildObjects(DbSet<User> objects)
	    {
	        return objects.ToList();
	    }

	    public bool OkUser(string name, string pwd)
	    {
	        List<User> matchingUsers = All.Where(u => u.Name == name && u.Password == pwd).ToList();

	        return (matchingUsers.Count > 0);


	    }
    }
}