﻿namespace SupportTicketSystem.Data.Base
{
    public abstract class DomainClassBase : IDomainClass
    {
        public abstract int GetId();
        public abstract void SetId(int id);

        public IDomainClass Copy()
        {
            return (MemberwiseClone() as IDomainClass);
        }
    }
}