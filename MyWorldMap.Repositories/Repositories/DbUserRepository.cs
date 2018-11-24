using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace MyWorldMapApp.Repositories
{
    public class DbUserRepository : IUserRepository
    {
        public int Add(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public void Edit(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public UserDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

