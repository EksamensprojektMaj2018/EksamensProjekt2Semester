﻿namespace SupportTicketSystem.Data.Base
{
    public interface IDomainClass
    {
        int GetId();

        void SetId(int id);

        IDomainClass Copy();

        bool IsValid { get; }
    }
}