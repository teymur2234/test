using ClickUp_Task.DTOs.UserDTOs;
using ClickUp_Task.Entity;

namespace ClickUp_Task.DTOs.RoleDTOs
{
    public record RoleByIdDto
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public List<UserByIdDto> Users { get; set; }
    }
}
