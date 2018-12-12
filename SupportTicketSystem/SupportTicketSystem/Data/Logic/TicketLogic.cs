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
    }
}