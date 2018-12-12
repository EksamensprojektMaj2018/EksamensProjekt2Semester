using SupportTicketSystem.Model.Catalog;
using SupportTicketSystem.ViewModel.Base;

namespace SupportTicketSystem.ViewModel.Data
{
    public class TicketDataViewModel : DataViewModelAppBase<Ticket>
    {
        private TicketCatalog _ticketCatalog;
        private Ticket _newTicket;

        public TicketDataViewModel()
        {
            //_ticketCatalog = new TicketCatalog();
            //_newTicket = new Ticket();
            //_ticketCatalog = DataObject().Category == null ? null 
        }

        public string Topic
        {
            get { return DataObject().Topic; }
            set
            {
                DataObject().Topic = value;
                OnPropertyChanged();
            }
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

        public int Catagory
        {
            get { return DataObject().Category; }
            set
            {
                DataObject().Category = value;
                OnPropertyChanged();
            }
        }

        protected override string ItemDescription { get; }
    }
}