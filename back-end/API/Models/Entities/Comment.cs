namespace API.Models.Entities
{
    public enum EntityType
    {
        Customer,
        Deal,
        Reservation
    }
    public class Comment : BaseEntity
    {
        public Comment(Guid createdBy, Guid entityId, EntityType entityType, string content)
        {
            CreatedBy = createdBy;
            EntityId = entityId;
            EntityType = entityType;
            Content = content;
        }

        public Guid CreatedBy { get; set; }
        public User User { get; set; }

        public Guid EntityId { get; set; } 
        public EntityType EntityType { get; set; } 

        public string Content { get; set; }
    }
}
