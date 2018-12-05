﻿using System.Collections.ObjectModel;

namespace SupportTicketSystem.ViewModel.Base
{
    public interface IPageViewModel<TDataViewModel>
    {
        ObservableCollection<TDataViewModel> ItemCollection { get; }

        TDataViewModel ItemSelected { get; set; }

        TDataViewModel ItemDetails { get; set; }

        void SetStatus(PageViewModelStatus newStatus);
    }
}