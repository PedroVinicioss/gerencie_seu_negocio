using Microsoft.AspNetCore.Identity;

namespace API.Models.Entities
{
    public class User : IdentityUser<Guid>
    {
        public User() { }
        public User(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
            UserName = email;
        }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedDate { get; set; }
        public string FullName { get; set; }
        public ICollection<UserWorkstation> Workstations { get; set; } = new List<UserWorkstation>();

        public void SetDeleted()
        {
            DeletedDate = DateTime.UtcNow;
            IsActive = false;
        }
    }
}
