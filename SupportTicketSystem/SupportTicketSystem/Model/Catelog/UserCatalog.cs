using System;
using System.Data.SqlClient;
using System.Linq;



namespace SupportTicketSystem.Model.Catelog
{
    public class UserCatalog
    {
        public partial class MainPage
        {
            SqlConnection sqlc = new SqlConnection();
            sqlc.ConnectionString = "";

            SqlCommand sqlm =
                new SqlCommand("select count (*) as cnt from login_database where username=@usr and password=@pwd",
                    sqlc);

            sqlm.Parameters.Clear();
            sqlm.Parameters.AddWithValue("@usr", txt_Username.Text);
            sqlm.Parameters.AddWithValue("@pwd", txt_Password.Text);
            sqlc.Open();

        }
    }
}