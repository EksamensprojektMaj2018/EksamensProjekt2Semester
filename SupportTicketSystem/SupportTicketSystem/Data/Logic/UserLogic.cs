using SupportTicketSystem.Model.App;

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
        //public override string ToString()
        //{
        //    return Name;
        //}
        //public string RoleText
        //{
        //    get { return DomainModel.GetCatalog<Role>().Read(Role).RoleName; }
        //}
    }
}