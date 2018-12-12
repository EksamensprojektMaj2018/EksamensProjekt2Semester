using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SupportTicketSystem.Model.Catalog;

namespace SupportTicketSystem.ViewModel
{
    public class TicketPageViewModel : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}