namespace ClickUp_Task.DTOs.UserDTOs
{
    public record UserToUpdateDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
