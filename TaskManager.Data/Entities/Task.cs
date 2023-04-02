using TaskManager.Contracts.Models.Enumerations;

namespace TaskManager.Data.Entities
{
    public class Task : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public long? TaskCategoryId { get; set; }
        public long? AssignedToUserId { get; set; }
        public long? CreatedByUserId { get; set; }
        public PriorityLevel Priority { get; set; }
        public TaskImplementationStatus Status { get; set; }
        public DateTime DeadLine { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
