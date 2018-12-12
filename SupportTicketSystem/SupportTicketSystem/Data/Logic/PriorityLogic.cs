namespace SupportTicketSystem
{
    public partial class Priority
    {
        public override int GetId()
        {
            return PriorityId;
        }

        public override void SetId(int id)
        {
            PriorityId = id;
        }
    }
}