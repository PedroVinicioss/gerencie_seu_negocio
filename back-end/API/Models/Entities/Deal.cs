using Microsoft.EntityFrameworkCore;

namespace API.Models.Entities
{
    public enum DealStatus
    {
        Open,
        Won,
        Lost
    }

    public class Deal : BaseEntity
    {
        public Deal(Guid workstationId, string name, decimal amount, DealStatus status, Guid customerId)
        {
            WorkstationId = workstationId;
            Name = name;
            Amount = amount;
            Status = status;
            CustomerId = customerId;

            Products = [];
        }

        public Guid WorkstationId { get; set; }
        public Workstation Workstation { get; set; }

        public string Name { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        public DealStatus Status { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Product> Products { get; set; }
    }

}
