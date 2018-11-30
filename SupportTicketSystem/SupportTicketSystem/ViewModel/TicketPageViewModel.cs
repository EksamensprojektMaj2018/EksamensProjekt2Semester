using System.Collections.Generic;
using SupportTicketSystem.Model;

namespace SupportTicketSystem.ViewModel
{
    public class TicketPageViewModel
    {
        private TicketCatalog _ticketCatalog;

        public TicketPageViewModel()
        {
            _ticketCatalog = new TicketCatalog();
        }
        public List<Ticket> AllTickets
        {
            get { return _ticketCatalog.ShowAll; }
        }
    }
}