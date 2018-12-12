using System.Collections.ObjectModel;

namespace SupportTicketSystem.ViewModel.Base
{
    public interface IPageViewModel<TDataViewModel>
    {
        ObservableCollection<TDataViewModel> ItemCollection { get; }

        TDataViewModel ItemSelected { get; set; }

        TDataViewModel ItemDetails { get; }

        void SetStatus(PageViewModelStatus newStatus);
    }
}