using System.Collections.Generic;
using System.Linq;

namespace SupportTicketSystem.Model.Catalog
{
	public class UserCatalog
	{
		private SupportticketdbContext _dbContext;

		public UserCatalog()
		{
			_dbContext = new SupportticketdbContext();
		}

		public List<User> ShowAll
		{
			get
			{
				List<User> AllUsers = _dbContext.Users.ToList();
				return AllUsers;
			}
		}
	}
}