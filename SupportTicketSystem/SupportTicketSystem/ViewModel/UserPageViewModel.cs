using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SupportTicketSystem.Model.Catelog;

namespace SupportTicketSystem.ViewModel
{
	public class UserPageViewModel : INotifyPropertyChanged
	{
		private UserCatalog _userCatalog;
		private User _userSelected;

		public UserPageViewModel()
		{
			_userCatalog = new UserCatalog();
			_userSelected = null;
		}
		public List<User> AllUsers
		{
			get { return _userCatalog.ShowAll; }
		}
		public User UserSelected
		{
			get { return _userSelected; }
			set
			{
				_userSelected = value;
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