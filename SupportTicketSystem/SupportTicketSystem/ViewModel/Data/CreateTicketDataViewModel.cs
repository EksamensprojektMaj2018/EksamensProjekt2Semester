using SupportTicketSystem.Model.Catalog;
using SupportTicketSystem.ViewModel.Base;

namespace SupportTicketSystem.ViewModel.Data
{
    public class CreateTicketDataViewModel : DataViewModelAppBase<CreateTicket>
    {
        private TicketCatalog _ticketCatalog;
        private Ticket _newTicket;

        public CreateTicketPageViewModel(CreateTicket dataObject) : base(dataObject)
        {
            //_ticketCatalog = new TicketCatalog();
            //_newTicket = new Ticket();
            _ticketCatalog = DataObject().
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
    }
}