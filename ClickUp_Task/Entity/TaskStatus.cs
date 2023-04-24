using Microsoft.Identity.Client;

namespace ClickUp_Task.Entity
{
    public class TaskStatus
    {
        public int TaskStatusId { get; set; }
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        public bool IsDeleted { get; set; }
    }
}
