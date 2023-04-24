using ClickUp_Task.DTOs.UserDTOs;

namespace ClickUp_Task.DTOs.RoleDTOs
{
    public record RoleToListDto
    {
        public string Name { get; set; }
        public List<UserToLIstDto> Users { get; set; }
    }
}
