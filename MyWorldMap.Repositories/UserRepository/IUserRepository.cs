using MyWorldMapApp.Database;
using System.Collections.Generic;

namespace MyWorldMapApp.Repositories
{
    public interface IUserRepository
    {
            User Get(int id);
            IEnumerable<User> GetAll();
            int Add(UserViewModel user);
            void Edit(UserViewModel user);
            void Delete(UserViewModel user);
    }
}
