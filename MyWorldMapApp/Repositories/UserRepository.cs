using System.Collections.Generic;
using System.Linq;
using MyWorldMapApp.Data;

namespace MyWorldMapApp.Repositories
{
    public class UserRepository : IUserRepository
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
            return _allUsers.Select(x => new UserDTO
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Id = x.Id,
                VisitedCountries = x.VisitedCountries.Select(y => new TravelDestinationDTO
                {
                    Id = y.Id,
                    Name = y.Name
                }).ToList()
            });
        }

        public UserDTO Get(int id)
        {
            return _allUsers.Select(x => new UserDTO
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Id = x.Id,
                VisitedCountries = x.VisitedCountries.Select(y => new TravelDestinationDTO
                {
                    Id = y.Id,
                    Name = y.Name
                }).ToList()
            }).SingleOrDefault(x => x.Id == id);
        }
       
        public int Add(UserDTO user)
        {
            var userToAdd = new User {
                Id = _allUsers.Max(x => x.Id) + 1,
                FirstName = user.FirstName,
                LastName = user.LastName,
                VisitedCountries = user.VisitedCountries.Select(y => new TravelDestination
                {
                    Id = y.Id,
                    Name = y.Name
                }).ToList()
            };
            _allUsers.Add(userToAdd);
            return userToAdd.Id;    
        }

        public void Edit(UserDTO user)
        {
            var originalUser = _allUsers.Find(x=> x.Id == user.Id);
            originalUser.Id = user.Id;
            originalUser.FirstName = user.FirstName;
            originalUser.LastName = user.LastName;
            originalUser.VisitedCountries = user.VisitedCountries.Select(y => new TravelDestination
            {
                Id = y.Id,
                Name = y.Name
            }).ToList();
    }

        public void Delete(UserDTO user)
        {
            var userToDelete = _allUsers.Find(x => x.Id == user.Id);
            _allUsers.Remove(userToDelete);
        } 
    }
}
