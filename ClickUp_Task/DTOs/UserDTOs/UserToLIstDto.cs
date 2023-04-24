using ClickUp_Task.DTOs.RoleDTOs;
using ClickUp_Task.DTOs.TaskDTOs;
using ClickUp_Task.Entity;

namespace ClickUp_Task.DTOs.UserDTOs
{
    public record UserToLIstDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public List<TaskToListDto> Tasks { get; set; }
    }
}
