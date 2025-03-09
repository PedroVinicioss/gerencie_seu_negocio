namespace API.Models.Entities
{
    public class Workstation : BaseEntity
    {
        public Workstation(string name, string description)
        {
            Name = name;
            Description = description;

            Users = [];
            Customers = [];
            Transactions = [];
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<UserWorkstation> Users { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
