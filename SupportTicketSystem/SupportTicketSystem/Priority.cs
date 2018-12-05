using System.Collections.Generic;

namespace SupportTicketSystem
{
    public partial class Priority
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
