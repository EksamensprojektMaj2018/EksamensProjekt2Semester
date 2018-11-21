using System;
using System.Collections.Generic;

namespace SupportTicketSystem
{
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public string Message { get; set; }
        public int Priority { get; set; }
        public string Topic { get; set; }
        public int Category { get; set; }

        public Category CategoryNavigation { get; set; }
        public Priority PriorityNavigation { get; set; }
    }
}
