using System;
using SupportTicketSystem.Data.Base;

namespace SupportTicketSystem
{
    public partial class Category
    {
        public override int GetId()
        {
            return CategoryId;
        }

        public override void SetId(int id)
        {
            CategoryId = id;
        }
        public override string ToString()
        {
            return CategoryName;
        }
    }
}