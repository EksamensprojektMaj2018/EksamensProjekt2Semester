using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SupportTicketSystem.Model.Catalog;
using SupportTicketSystem.ViewModel.Base;
using SupportTicketSystem.ViewModel.Data;

namespace SupportTicketSystem.ViewModel
{
	public class UserPageViewModel : PageViewModelAppBase<User, UserDataViewModel>
    {
        //private UserCatalog _userCatalog;
        //private User _userSelected;

        public UserPageViewModel()
        {
            SetState(PageViewModelStatus.Open);
            //_userCatalog = new UserCatalog();
            //_userSelected = null;
        }
        //public List<User> AllUsers
        //{
        //	get { return _userCatalog.All; }
        //}
        //public User UserSelected
        //{
        //	get { return _userSelected; }
        //	set
        //	{
        //		_userSelected = value;
        //		OnPropertyChanged();
        //	}
        //}

        //public event PropertyChangedEventHandler PropertyChanged;
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //	PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}