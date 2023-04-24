using ClickUp_Task.Entity;

namespace ClickUp_Task.DTOs.RoleDTOs
{
    public record RoleToIsDeletedDto
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
