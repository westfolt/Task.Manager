namespace TaskManager.Data.Entities
{
    public class TaskComment : BaseEntity
    {
        public long TaskId { get; set; }
        public long UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
