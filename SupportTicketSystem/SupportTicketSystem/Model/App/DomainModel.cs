using System;
using SupportTicketSystem.Model.Base;
using SupportTicketSystem.Model.Catalog;
using SupportTicketSystem.Model.Catelog;


namespace SupportTicketSystem.Model.App
{
    public class DomainModel
    {
        private static DomainModel _instance;
        public static DomainModel Instance { get { return _instance ?? (_instance = new DomainModel()); } }

        private ICatalog<Category> Categorys { get; }
        private ICatalog<Priority> Prioritys { get; }
        private ICatalog<Role> Roles { get; }
        private ICatalog<Ticket> Ticketss { get; }
        private ICatalog<User> Users { get; }


        private DomainModel()
        {
            Categorys = new CategoryCatalog();
            Categorys = new PriorityCatalog();
            Categorys = new RoleCatalog();
            Categorys = new TicketCatalog();
            Categorys = new UserCatalog();
        }

        public static ICatalog<T> GetCatalog<T>()
        {
            if (typeof(T) == typeof(Category))
            {
                return (ICatalog<T>)Instance.Categorys;
            }

            if (typeof(T) == typeof(Priority))
            {
                return (ICatalog<T>)Instance.Prioritys;
            }

            if (typeof(T) == typeof(Role))
            {
                return (ICatalog<T>)Instance.Roles;
            }

            if (typeof(T) == typeof(Ticket))
            {
                return (ICatalog<T>)Instance.Ticketss;
            }

            if (typeof(T) == typeof(User))
            {
                return (ICatalog<T>)Instance.Users;
            }

            throw new ArgumentException($"No Catalog found for type {typeof(T)}");
        }
    }
}