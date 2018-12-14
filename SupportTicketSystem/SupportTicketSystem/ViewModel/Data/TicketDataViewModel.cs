using System.Collections.Generic;
using SupportTicketSystem.Model.App;
using SupportTicketSystem.ViewModel.Base;

namespace SupportTicketSystem.ViewModel.Data
{
    public class TicketDataViewModel : DataViewModelAppBase<Ticket>
    {
        public List<Priority> _priorityList;
        public Priority _prioritySelected;
        public List<Category> _categoryList;
        public Category _categorySelected;
        public TicketDataViewModel()
        {
            _priorityList = DomainModel.GetCatalog<Priority>().All;
            _categoryList = DomainModel.GetCatalog<Category>().All;
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
        public List<Category> CategoryList
        {
            get { return _categoryList; }
        }
        public Category CategorySelected
        {
            get { return _categorySelected; }
            set
            {
                _categorySelected = value;
                DataObject().Category = _categorySelected.CategoryId;
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