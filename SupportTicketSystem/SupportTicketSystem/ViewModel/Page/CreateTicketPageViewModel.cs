using SupportTicketSystem.ViewModel.Base;
using SupportTicketSystem.ViewModel.Data;

namespace SupportTicketSystem.ViewModel.Page
{
    public class CreateTicketPageViewModel : PageViewModelAppBase<Ticket, TicketDataViewModel>
    {
        public CreateTicketPageViewModel()
        {
            SetState(PageViewModelStatus.Create);
        }
    }
}