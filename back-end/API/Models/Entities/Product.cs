using Microsoft.EntityFrameworkCore;

namespace API.Models.Entities
{
    public class Product : BaseEntity
    {
        public Product(Guid workstationId, string name, string description, decimal price)
        {
            WorkstationId = workstationId;
            Name = name;
            Description = description;
            Price = price;
        }

        public Guid WorkstationId { get; set; }
        public Workstation Workstation { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
    }
}
