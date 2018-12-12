using System.Collections.Generic;
using SupportTicketSystem.Data.Base;

namespace SupportTicketSystem
{
    public partial class Priority : DomainClassBase
    {
        public Priority()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int PriorityId { get; set; }
        public string PriorityName { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
