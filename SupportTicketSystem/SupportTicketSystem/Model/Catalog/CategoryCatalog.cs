using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Model.Base;

namespace SupportTicketSystem.Model.Catalog
{
    public class CategoryCatalog : CatalogAppBase<Category>
    {
        public override List<Category> BuildObjects(DbSet<Category> objects)
        {
            return objects.ToList();
        }

    }
}