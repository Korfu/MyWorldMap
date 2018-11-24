using MyWorldMapApp.Database;
using System.Collections.Generic;

namespace MyWorldMapApp.Repositories
{
    public interface IUserRepository
    {
            UserDTO Get(int id);
            IEnumerable<UserDTO> GetAll();
            int Add(UserDTO user);
            void Edit(UserDTO user);
            void Delete(UserDTO user);
    }
}
