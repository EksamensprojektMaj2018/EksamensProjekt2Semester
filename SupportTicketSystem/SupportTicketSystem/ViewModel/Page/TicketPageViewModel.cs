using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SupportTicketSystem.Model.Catalog;
using SupportTicketSystem.ViewModel.Base;
using SupportTicketSystem.ViewModel.Data;

namespace SupportTicketSystem.ViewModel.Page
{
    public class TicketPageViewModel : PageViewModelAppBase<Ticket, TicketDataViewModel>
    {
        private TicketCatalog _ticketCatalog;
        private Ticket _ticketSelected;

        public TicketPageViewModel()
        {
            _ticketCatalog = new TicketCatalog();
            _ticketSelected = null;
        }
        public List<Ticket> AllTickets
        {
            get { return _ticketCatalog.All; }
        }
        public Ticket TicketSelected
        {
            get { return _ticketSelected; }
            set
            {
                _ticketSelected = value;
                OnPropertyChanged();
            }
        }
    }
}