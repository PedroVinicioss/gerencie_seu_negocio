namespace API.Models.Entities
{
    public enum UserRole
    {
        Admin,
        Manager,
        StandardUser
    }
    public class UserWorkstation
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid WorkstationId { get; set; }
        public Workstation Workstation { get; set; }

        public UserRole Role { get; set; }
    }
}
