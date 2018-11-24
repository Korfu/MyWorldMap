using MyWorldMap.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWorldMap.Repositories
{
    public interface IUserRepository
    {
            User Get(int id);
            IEnumerable<User> GetAll();
            int Add(User user);
            void Edit(User user);
            void Delete(User user);
    }
}
