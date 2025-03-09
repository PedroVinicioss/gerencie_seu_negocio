using Microsoft.EntityFrameworkCore;

namespace API.Models.Entities
{
    public enum ReservationStatus
    {
        Pending,   
        Confirmed,
        Canceled,  
        CheckedIn, 
        CheckedOut,
        Completed
    }

    public class Reservation : BaseEntity
    {
        public Reservation(Guid workstationId, DateTime checkin, DateTime checkout, ReservationStatus status, Guid roomId, decimal amount, PaymentType paymentType, Guid customerId)
        {
            WorkstationId = workstationId;
            Checkin = checkin;
            Checkout = checkout;
            Status = status;
            RoomId = roomId;
            Amount = amount;
            PaymentType = paymentType;
            CustomerId = customerId;
        }
        public Guid WorkstationId { get; set; }
        public Workstation Workstation { get; set; }

        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public ReservationStatus Status { get; set; }

        public Guid RoomId { get; set; }
        public Room Room { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        public PaymentType PaymentType { get; set; }

        public ICollection<Product> Products { get; set; } 
    }

}
