using ClickUp_Task.Entity;

namespace ClickUp_Task.DTOs.TaskDTOs
{
    public record TaskToAddDto
    {
        public string Desciption { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int TaskStatusId { get; set; }
    }
}
