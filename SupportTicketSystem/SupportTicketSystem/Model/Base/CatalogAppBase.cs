using SupportTicketSystem.Data.Base;

namespace SupportTicketSystem.Model.Base
{
    public abstract class CatalogAppBase<T> : CatalogEFBase<T, SupportticketdbContext>
        where T : class, IDomainClass
    {
    }
}