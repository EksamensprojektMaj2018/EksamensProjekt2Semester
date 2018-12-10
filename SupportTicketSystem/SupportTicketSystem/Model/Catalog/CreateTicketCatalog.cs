namespace SupportTicketSystem.Model.Catelog
{
    public class CreateTicketCatalog
    {
        private SupportticketdbContext _dbContext;
        public CreateTicketCatalog()
        {
            _dbContext = new SupportticketdbContext();
        }


        public void Create(Ticket aTicket)
        {
            _dbContext.Tickets.Add(aTicket);
            _dbContext.SaveChanges();
        }
    }
}