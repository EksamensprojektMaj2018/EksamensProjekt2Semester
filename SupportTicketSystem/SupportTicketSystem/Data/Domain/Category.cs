using System.Collections.Generic;
using SupportTicketSystem.Data.Base;

namespace SupportTicketSystem
{
    public partial class Category : DomainClassBase
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
