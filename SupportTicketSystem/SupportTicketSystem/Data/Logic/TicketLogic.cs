﻿using SupportTicketSystem.Model.App;

namespace SupportTicketSystem
{
    public partial class Ticket
    {
        public override int GetId()
        {
            return TicketId;
        }

        public override void SetId(int id)
        {
            TicketId = id;
        }

        public Ticket()
        {
            Category = 1;
            Priority = 1;
            UserId = 2;
        }

        public string PriorityText
        {
            get { return DomainModel.GetCatalog<Priority>().Read(Priority).PriorityName; }
        }
        public string CategoryText
        {
            get { return DomainModel.GetCatalog<Category>().Read(Category).CategoryName; }
        }
    }
}