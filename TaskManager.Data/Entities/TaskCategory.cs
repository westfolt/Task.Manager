namespace TaskManager.Data.Entities
{
    public class TaskCategory : BaseEntity
    {
        public string Name { get; set; }
        public long UserProfileId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
