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

        public UserPageViewModel()
        {
            SetState(PageViewModelStatus.Open);
        }
    }
}