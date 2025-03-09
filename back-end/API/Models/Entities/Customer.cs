namespace API.Models.Entities
{
    public enum BiologicalSex
    {
       Male,
       Female
    }
    public class Customer : BaseEntity
    {
        public Customer() { }
        public Customer(Guid workstationId, string fullName, string email, string cpf, DateTime birthDate, BiologicalSex sex, string postalCode, string address, string state, string city, string occupation)
        {
            WorkstationId = workstationId;

            FullName = fullName;
            Email = email;
            CPF = cpf;
            BirthDate = birthDate;
            BiologicalSex = sex;
            PostalCode = postalCode;
            Address = address;
            State = state;
            City = city;
            Occupation = occupation;
        }

        public Guid WorkstationId { get; set; }
        public Workstation Workstation { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
        public BiologicalSex BiologicalSex { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Occupation { get; set; }
    }
}
