using ClickUp_Task.Entity;
using Microsoft.EntityFrameworkCore;

namespace ClickUp_Task.DAL
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Entity.TaskStatus> TaskStatuses { get; set; }
        public DbSet<Entity.Task> Tasks { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasQueryFilter(m=> !m.IsDeleted);
            modelBuilder.Entity<Role>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Entity.TaskStatus>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Entity.Task>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Group>().HasQueryFilter(m => !m.IsDeleted);
        }
    }
}
