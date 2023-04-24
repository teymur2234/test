namespace ClickUp_Task.Entity
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        public List<User> Users { get; set; }
        public bool IsDeleted { get; set; }
    }
}
