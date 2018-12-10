using SupportTicketSystem.Data.Base;
using SupportTicketSystem.Model.Base;
using SupportTicketSystem.ViewModel.Base;

namespace SupportTicketSystem.Command.Base
{
    public abstract class CRUDCommandBase<T, TDataViewModel> : CommandBase
        where TDataViewModel : IDataViewModel<T>
        where T : IDomainClass
    {
        protected ICatalog<T> _catalog;
        protected IPageViewModel<TDataViewModel> _pageViewModel;

        protected CRUDCommandBase(ICatalog<T> catalog, IPageViewModel<TDataViewModel> pageViewModel)
        {
            _catalog = catalog;
            _pageViewModel = pageViewModel;
        }

        /// <summary>
        /// CRUD-commands kan kun udføres, når ItemDetails refererer til et objekt. 
        /// </summary>
        /// <returns></returns>
        protected override bool CanExecute()
        {
            return (_pageViewModel.ItemDetails != null) && (_pageViewModel.ItemDetails.DataObject() != null);
        }
    }
}