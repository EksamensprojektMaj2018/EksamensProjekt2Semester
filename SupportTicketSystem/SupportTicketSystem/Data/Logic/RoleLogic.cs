namespace SupportTicketSystem
{
    public partial class Role
    {
        public override int GetId()
        {
            return RoleId;
        }

        public override void SetId(int id)
        {
            RoleId = id;
        }
    }
}