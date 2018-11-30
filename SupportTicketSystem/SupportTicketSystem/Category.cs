using System;
using System.Collections.Generic;

namespace SupportTicketSystem
{
    public partial class Category
    {
        public Category()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int CategoryId { get; set; }
        public string Category1 { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
