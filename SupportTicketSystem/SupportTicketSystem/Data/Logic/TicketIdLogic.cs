using SupportTicketSystem.Data.Base;
namespace SupportTicketSystem
{
    public partial class Ticket : DomainClassBase
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