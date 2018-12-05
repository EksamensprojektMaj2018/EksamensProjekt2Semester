namespace SupportTicketSystem
{
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public string Message { get; set; }
        public int Priority { get; set; }
        public string Topic { get; set; }
        public int Category { get; set; }
        public int UserId { get; set; }

        public Category CategoryNavigation { get; set; }
        public Priority PriorityNavigation { get; set; }
        public User User { get; set; }

        public override string ToString()
        {
            return Topic;
        }
    }
}
