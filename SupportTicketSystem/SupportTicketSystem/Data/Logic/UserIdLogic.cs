using SupportTicketSystem.Data.Base;

namespace SupportTicketSystem
{
    public partial class User : DomainClassBase
    {
        public override int GetId()
        {
            return UserId;
        }

        public override void SetId(int id)
        {
            UserId = id;
        }

    }
}