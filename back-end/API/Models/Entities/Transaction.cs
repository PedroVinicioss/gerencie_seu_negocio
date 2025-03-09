using Microsoft.EntityFrameworkCore;

namespace API.Models.Entities
{
    public enum TransactionType
    {
        Income,  
        Expense  
    }

    public enum PaymentType
    {
        CreditCard,
        DebitCard,
        Cash,
        BankTransfer,
        Pix
    }

    public enum RelatedEntityType
    {
        Deal,
        Reservation
    }

    public class Transaction : BaseEntity
    {
        public Transaction() { }
        public Transaction(Guid workstationId, decimal amount, TransactionType type, PaymentType paymentType,
                           RelatedEntityType? relatedEntityType, Guid? relatedEntityId = null)
        {
            WorkstationId = workstationId;

            Amount = amount;
            Type = type;
            PaymentType = paymentType;
            RelatedEntityId = relatedEntityId;
            RelatedEntityType = relatedEntityType;
        }

        public Guid WorkstationId { get; set; }
        public Workstation Workstation { get; set; }

        [Precision(18, 2)]
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public PaymentType PaymentType { get; set; }

        public Guid? RelatedEntityId { get; set; }
        public RelatedEntityType? RelatedEntityType { get; set; } 
    }
}
