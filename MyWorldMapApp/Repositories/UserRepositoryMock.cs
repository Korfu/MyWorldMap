using System.Collections.Generic;
using System.Linq;
using MyWorldMapApp.Dto;
using MyWorldMapApp.Web.Data;
using MyWorldMapApp.Web.DTO;
using MyWorldMapApp.Web.Transformators;

namespace MyWorldMapApp.Web.Repositories
{
    public class UserRepositoryMock : IUserRepository
    {
        public static List<User> _allUsers = new List<User> {
        new User {
             FirstName="Konrad",
             LastName="Korf",
             Id=1,
             VisitedCountries= new List<TravelDestination>
                 {
                     new TravelDestination
                     {
                         Id=1,
                         Name="Poland"
                     },
                     new TravelDestination
                     {
                         Id=2,
                         Name="USA"
                     },
                     new TravelDestination
                     {
                         Id=3,
                         Name="Argentina"
                     },
                 }
             },
        new User {
             FirstName="Martyna",
             LastName="Zajączkowska",
             Id=2,
             VisitedCountries= new List<TravelDestination>
                 {
                     new TravelDestination
                     {
                        Id=1,
                        Name="Poland"
                     }
                 }
            },
        };

        public IEnumerable<UserDTO> GetAll()
        {
            return UserListTransformator.Map(_allUsers);
        }

        public UserDTO Get(int id)
        {
            var user = _allUsers.SingleOrDefault(x => x.Id == id);
            return UserTransformator.Map(user);
        }
       
        public int Add(UserDTO user)
        {
            var userToAdd = new UserDTO {
                Id = _allUsers.Max(x => x.Id) + 1,
                FirstName = user.FirstName,
                LastName = user.LastName,
                VisitedCountries = user.VisitedCountries.Select(y => new TravelDestinationDTO
                {
                    Id = y.Id,
                    Name = y.Name
                }).ToList()
            };

            _allUsers.Add(UserTransformator.Map(userToAdd));

            return userToAdd.Id;    
        }

        public void Edit(UserDTO user)
        {
            var originalUser = _allUsers.Find(x=> x.Id == user.Id);
            UserTransformator.Map(originalUser);
    }

        public void Delete(UserDTO user)
        {
            var userToDelete = _allUsers.Find(x => x.Id == user.Id);
            _allUsers.Remove(userToDelete);
        } 
    }
}
