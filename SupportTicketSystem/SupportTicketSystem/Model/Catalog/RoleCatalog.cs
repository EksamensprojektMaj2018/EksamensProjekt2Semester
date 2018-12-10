using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Model.Base;

namespace SupportTicketSystem.Model.Catalog
{
    public class RoleCatalog
    {
        public class RoleCatalog : CatalogAppBase<Role>
        {
            public override List<Role> BuildObjects(DbSet<Role> objects)
            {
                return objects.ToList();
            }
        }
    }
}