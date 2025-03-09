namespace API.Models.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }

        public void SetDeleted()
        {
            DeletedDate = DateTime.Now;
        }
    }
}
