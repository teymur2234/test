﻿namespace ClickUp_Task.Entity
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public List<User>? Users { get; set; }
        public bool IsDeleted { get; set; }
    }
}
