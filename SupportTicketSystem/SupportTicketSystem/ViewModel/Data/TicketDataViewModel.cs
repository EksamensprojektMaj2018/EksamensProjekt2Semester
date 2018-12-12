using System.Collections.Generic;
using SupportTicketSystem.Model.App;
using SupportTicketSystem.Model.Catalog;
using SupportTicketSystem.ViewModel.Base;

namespace SupportTicketSystem.ViewModel.Data
{
    public class TicketDataViewModel : DataViewModelAppBase<Ticket>
    {
        public List<Priority> _priorityList;
        public Priority _prioritySelected;
        public TicketDataViewModel()
        {
            _priorityList = DomainModel.GetCatalog<Priority>().All;
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
            get { return DataObject().Message; }
            set
            {
                DataObject().Message = value;
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

        public List<Priority> PriorityList
        {
            get { return _priorityList; }
        }
        public Priority PrioritySelected
        {
            get { return _prioritySelected; }
            set
            {
                _prioritySelected = value;
                DataObject().Priority = _prioritySelected.PriorityId;
                OnPropertyChanged();
            }
        }

        protected override string ItemDescription { get; }
    }
}