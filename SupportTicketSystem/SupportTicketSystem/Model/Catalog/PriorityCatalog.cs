using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Model.Base;

namespace SupportTicketSystem.Model.Catalog
{
    public class PriorityCatalog : CatalogAppBase<Priority>
    {
        public override List<Priority> BuildObjects(DbSet<Priority> objects)
        {
            return objects.ToList();
        }
    }
}