using SupportTicketSystem.Command.Base;
using SupportTicketSystem.ViewModel.Base;

namespace SupportTicketSystem.Command.App
{
    public class SetViewStatusCommand<TDataViewModel> : CommandBase
    {
        private IPageViewModel<TDataViewModel> _pageViewModel;
        private PageViewModelStatus _status;

        public SetViewStatusCommand(IPageViewModel<TDataViewModel> pageViewModel, PageViewModelStatus state)
        {
            _pageViewModel = pageViewModel;
            _status = PageViewModelStatus.Closed;
        }

        protected override void Execute()
        {
            _pageViewModel.SetStatus(_status);
        }
    }
}