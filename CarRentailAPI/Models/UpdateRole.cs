namespace CarRentailAPI.Models
{
    public class UpdateRole
    {
        public string userName { get; set; }
        public string RoleName { get; set; }

        public UpdateRole(){}

        public UpdateRole(string userName, string roleName)
        {
            this.userName = userName;
            RoleName = roleName;
        }
    }
}
