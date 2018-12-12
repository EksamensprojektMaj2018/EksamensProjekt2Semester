using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Model.Base;

namespace SupportTicketSystem.Model.Catalog
{
    public class TicketCatalog : CatalogAppBase<Ticket>
    {
        public override List<Ticket> BuildObjects(DbSet<Ticket> objects)
        {
            return objects.ToList();
        }
    }
}