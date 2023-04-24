namespace ClickUp_Task.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public List<Entity.Task> Tasks { get; set; }
        public List<Group> Groups { get; set; }
        public bool IsDeleted { get; set; }
    }
}
