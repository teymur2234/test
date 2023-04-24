using ClickUp_Task.Entity;

namespace ClickUp_Task.DTOs.UserDTOs
{
    public record UserToAddDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
