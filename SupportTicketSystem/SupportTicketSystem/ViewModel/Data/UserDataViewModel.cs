using System.Collections.Generic;
using SupportTicketSystem.Model.App;
using SupportTicketSystem.ViewModel.Base;

namespace SupportTicketSystem.ViewModel.Data
{
    public class UserDataViewModel : DataViewModelAppBase<User>
    {
        public List<Role> _roleList;
        public Role _roleSelected;
        public List<User> _userList;
        public User _userSelected;
        public UserDataViewModel()
        {
            _roleList = DomainModel.GetCatalog<Role>().All;
            _userList = DomainModel.GetCatalog<User>().All;
            _userSelected = null;
        }

        public string Name
        {
            get { return DataObject().Name; }
            set
            {
                DataObject().Name = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get { return DataObject().Email; }
            set
            {
                DataObject().Email = value;
                OnPropertyChanged();
            }
        }
        public string Company
        {
            get { return DataObject().Company; }
            set
            {
                DataObject().Company = value;
                OnPropertyChanged();
            }
        }
        public string RoleText
        {
            get { return DomainModel.GetCatalog<Role>().Read(DataObject().Role).RoleName; }
        }
        public User UserSelected
        {
            get { return _userSelected; }
            set
            {
                _userSelected = value;
                DataObject().UserId = _userSelected.UserId;
                OnPropertyChanged();
            }
        }
        protected override string ItemDescription
        {
            get { return DataObject().Name; }
        }
    }
}