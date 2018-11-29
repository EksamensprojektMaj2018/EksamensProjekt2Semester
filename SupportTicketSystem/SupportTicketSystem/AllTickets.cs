using System.Linq;
using Windows.UI.Xaml.Controls;

namespace SupportTicketSystem
{
    public class AllTickets
    {
       
        public void a()
        {
            SupportticketdbContext db = new SupportticketdbContext();
            var query = from a in db.Tickets select a;
            
        }

    }
}