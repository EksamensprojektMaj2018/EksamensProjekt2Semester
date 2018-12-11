using System.Collections.Generic;
using System.Linq;

namespace SupportTicketSystem.Model.Catalog
{
    public class TicketCatalog
    {
        private SupportticketdbContext _dbContext;

        public TicketCatalog()
        {
            _dbContext = new SupportticketdbContext();
        }

        public List<Ticket> ShowAll
        {
            get
            {
                List<Ticket> AllTickets = _dbContext.Tickets.ToList();
                return AllTickets;
            }
        }
        
    }
}