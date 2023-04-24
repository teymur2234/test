namespace ClickUp_Task.DTOs.TaskDTOs
{
    public record TaskByIdDto
    {
        public int TaskId { get; set; }
        public string Desciption { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int TaskStatusId { get; set; }
    }
}
