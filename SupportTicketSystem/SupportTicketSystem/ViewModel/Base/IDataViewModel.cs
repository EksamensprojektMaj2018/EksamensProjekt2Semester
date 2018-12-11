using SupportTicketSystem.Data.Base;

namespace SupportTicketSystem.ViewModel.Base
{
    public interface IDataViewModel<T> where T : IDomainClass
    {
        T DataObject();

        void SetDataObject(T obj);
    }
}