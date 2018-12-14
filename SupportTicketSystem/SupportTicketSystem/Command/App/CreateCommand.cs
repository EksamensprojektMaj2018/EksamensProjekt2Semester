using Windows.UI.Popups;
using SupportTicketSystem.Command.Base;
using SupportTicketSystem.Data.Base;
using SupportTicketSystem.Model.Base;
using SupportTicketSystem.Model.Catalog;
using SupportTicketSystem.ViewModel.Base;

namespace SupportTicketSystem.Command.App
{
    public class CreateCommand<T, TDataViewModel> : CRUDCommandBase<T, TDataViewModel>
        where TDataViewModel : IDataViewModel<T>
        where T : IDomainClass
    {
        MessageDialog msgbox = new MessageDialog("Din ticket er nu blevet oprettet!", "Vores support staff vil besvare din ticket hurtigst muligt");
        public CreateCommand(ICatalog<T> catalog, IPageViewModel<TDataViewModel> pageViewModel)
            : base(catalog, pageViewModel)
        {
        }
        private TicketCatalog _ticketCatalog;
        //public bool CanExecute(object parameter)
        //{
        //    return _ticketCatalog.OkUser(_pvm.UserName, _pvm.Password);
        //}
        protected override void Execute()
        {
            _catalog.Create(_pageViewModel.ItemDetails.DataObject());
            msgbox.ShowAsync();
        }
    }
}