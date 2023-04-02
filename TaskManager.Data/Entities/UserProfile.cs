namespace TaskManager.Data.Entities
{
    public class UserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AvatarUrl { get; set; }
    }
}
