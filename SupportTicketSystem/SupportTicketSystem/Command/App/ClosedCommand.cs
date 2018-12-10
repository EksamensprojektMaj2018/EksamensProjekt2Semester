using SupportTicketSystem.Command.Base;
using SupportTicketSystem.Data.Base;
using SupportTicketSystem.Model.Base;
using SupportTicketSystem.ViewModel.Base;

namespace SupportTicketSystem.Command.App
{
    public class ClosedCommand<T, TDataViewModel> : CRUDCommandBase<T, TDataViewModel>
        where TDataViewModel : IDataViewModel<T>
        where T : IDomainClass
    {
        public ClosedCommand(ICatalog<T> catalog, IPageViewModel<TDataViewModel> pageViewModel)
            : base(catalog, pageViewModel)
        {
        }

        protected override void Execute()
        {
            _catalog.Delete(_pageViewModel.ItemDetails.DataObject().GetId());
        }
    }
}