using System;
using System.Collections.Generic;

namespace SupportTicketSystem
{
    public partial class TicketList
    {
        public int UserId { get; set; }
        public int TicketId { get; set; }

        public Ticket Ticket { get; set; }
        public User User { get; set; }
    }
}
