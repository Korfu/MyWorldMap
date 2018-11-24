using MyWorldMap.Database;
using MyWorldMapApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWorldMap.Repositories
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
