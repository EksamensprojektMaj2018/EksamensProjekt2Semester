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
            Category = 0;
            Priority = 0;
            UserId = 2;
        }

        public override bool IsValid
        {
            get { return (Topic != null) && (Topic.Length > 10) && (Topic.Length < 50) && (Message !=null) && (Message.Length > 20) && (Priority > 0) && (Category > 0); }
        }
    }
}