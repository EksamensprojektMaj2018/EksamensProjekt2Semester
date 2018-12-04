using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SupportTicketSystem.Data.Base;
using SupportTicketSystem.Model.Base;

namespace SupportTicketSystem.ViewModel.Base
{
    public abstract class PageViewModelBase<T, TDataViewModel> : IPageViewModel<TDataViewModel>, INotifyPropertyChanged where TDataViewModel : class, IDataViewModel<T>, new() where T : IDomainClass, new()
        {
            protected ICatalog<T> _catalog;
            protected PageViewModelStatus _status;
            protected event Action<PageViewModelStatus> _viewStatusChanged;

            private TDataViewModel _itemSelected;
            protected TDataViewModel _itemDetails;


        protected PageViewModelBase()
        {
            _catalog.GetCatalog();
            _catalog.CatalogChanged += OnCatalogHasChanged;
        }

            public ObservableCollection<TDataViewModel> ItemCollection
            {
                get { return new ObservableCollection<TDataViewModel>(_catalog.All.Select(CreateDataViewModel).ToList());}
            }

        public TDataViewModel ItemSelected
        {
            get { return _itemSelected; }
            set
            {
                // I Create-tilstand skal Details sættes til et nyt "tomt" objekt.
                if (_status == PageViewModelStatus.Open)
                {
                    _itemSelected = null;
                    _itemDetails = CreateDataViewModel(new T());
                }

                // I Update-tilstand skal Details sættes til en kopi af det objekt,
                // Selected nu peger på.
                if (_status == PageViewModelStatus.Closed)
                {
                    _itemSelected = value;
                    _itemDetails = _itemSelected != null ? CreateDataViewModel((T)_itemSelected.DataObject().Copy()) : null;
                }

                OnPropertyChanged();
                OnPropertyChanged(nameof(ItemDetails));

                NotifyCommands();
            }
        }
            public TDataViewModel ItemDetails
            {
                get { return _itemDetails; }
            }

            private TDataViewModel CreateDataViewModel(T obj)
            {
                TDataViewModel dvmObj = new TDataViewModel();
                dvmObj.SetDataObject(obj);
                return dvmObj;
            }
            protected abstract ICatalog<T> GetCatalog();

            protected abstract void NotifyCommands();

            private void OnCatalogHasChanged(int obj)
            {
                OnPropertyChanged(nameof(ItemCollection));
            }

            protected virtual void OnViewStateChanged(PageViewModelStatus obj)
            {
                _viewStatusChanged?.Invoke(obj);
            }


        #region Kode for INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
    }
}