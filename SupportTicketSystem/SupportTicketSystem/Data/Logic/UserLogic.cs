namespace SupportTicketSystem
{
    public partial class User
    {
        public override int GetId()
        {
            return UserId;
        }

        public override void SetId(int id)
        {
            UserId = id;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}