using ClickUp_Task.Entity;

namespace ClickUp_Task.DAL.Abstract
{
    public interface IUserRepository
    {
        void Add(User entity );
        void Delete(int id);
        List<User> Get();
    }
}
