namespace ClickUp_Task.Entity
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Desciption { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }    
        public User User { get; set; }
        public int UserId { get; set; }
        public TaskStatus Status { get; set; }
        public int TaskStatusId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
