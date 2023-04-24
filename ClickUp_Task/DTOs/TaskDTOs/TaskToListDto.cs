using ClickUp_Task.DTOs.GroupDtos;
using ClickUp_Task.DTOs.TaskStatusDTOs;
using ClickUp_Task.DTOs.UserDTOs;
using ClickUp_Task.Entity;

namespace ClickUp_Task.DTOs.TaskDTOs
{
    public record TaskToListDto
    {
        public int TaskId { get; set; }
        public string Desciption { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int TaskStatusId { get; set; }
    }
}
