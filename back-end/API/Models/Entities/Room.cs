namespace API.Models.Entities
{
    public class Room : BaseEntity
    {
        public Room(Guid workstationId, string name, string description)
        {
            WorkstationId = workstationId;
            Name = name;
            Description = description;
        }

        public Guid WorkstationId { get; set; }
        public Workstation Workstation { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
