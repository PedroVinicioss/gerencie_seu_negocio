namespace API.Models.Entities
{
    public class User : BaseEntity
    {
        public User() { }
        public User(string fullName, string email, string password, string cpf)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            CPF = cpf;

            Workstations = [];
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CPF { get; set; }
        public ICollection<UserWorkstation> Workstations { get; set; }
    }
}
