using System.Collections.Generic;
using SupportTicketSystem.Model.Catalog;
using SupportTicketSystem.ViewModel.Base;
using SupportTicketSystem.ViewModel.Data;

namespace SupportTicketSystem.ViewModel.Page
{
    public class TicketPageViewModel : PageViewModelAppBase<Ticket, TicketDataViewModel>
    {

        public TicketPageViewModel()
        {
            SetState(PageViewModelStatus.Open);
        }
    }
}