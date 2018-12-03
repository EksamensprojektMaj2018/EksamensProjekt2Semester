using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SupportTicketSystem.Annotations;
using SupportTicketSystem.Model;

namespace SupportTicketSystem.ViewModel.Page
{
    public class CreateTicketPageViewModel : INotifyPropertyChanged
    {
        private TicketCatalog _ticketCatalog;
        private Ticket _newTicket;

        public CreateTicketPageViewModel()
        {
            _ticketCatalog = new TicketCatalog();
            _newTicket = new Ticket();
        }

        public string Message
        {
            get { return _newTicket.Message; }
            set
            {
                _newTicket.Message = value; 
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}