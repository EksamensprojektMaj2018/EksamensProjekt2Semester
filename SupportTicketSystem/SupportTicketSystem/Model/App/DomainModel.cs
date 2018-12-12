using System;
using SupportTicketSystem.Model.Base;
using SupportTicketSystem.Model.Catalog;


namespace SupportTicketSystem.Model.App
{
    public class DomainModel
    {
        private static DomainModel _instance;
        public static DomainModel Instance { get { return _instance ?? (_instance = new DomainModel()); } }

        private ICatalog<Category> Categorys { get; }
        private ICatalog<Priority> Prioritys { get; }
        private ICatalog<Role> Roles { get; }
        private ICatalog<Ticket> Tickets { get; }
        private ICatalog<User> Users { get; }


        private DomainModel()
        {
            Categorys = new CategoryCatalog();
            Prioritys = new PriorityCatalog();
            Roles = new RoleCatalog();
            Tickets = new TicketCatalog();
            Users = new UserCatalog();
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
                return (ICatalog<T>)Instance.Tickets;
            }

            if (typeof(T) == typeof(User))
            {
                return (ICatalog<T>)Instance.Users;
            }

            throw new ArgumentException($"No Catalog found for type {typeof(T)}");
        }
    }
}