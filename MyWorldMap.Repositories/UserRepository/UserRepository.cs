using System.Collections.Generic;
using System.Linq;
using MyWorldMapApp.Database;

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

        public IEnumerable<User> GetAll()
        {
            return _allUsers;
        }

        public User Get(int id)
        {
            return _allUsers.SingleOrDefault(x => x.Id == id);
        }
       
        public int Add(UserViewModel user)
        {
            var userToAdd =  new User {
                Id = _allUsers.Max(x => x.Id) + 1,
                FirstName= user.FirstName,
                LastName = user.LastName,
                VisitedCountries = (IList<TravelDestination>) user.VisitedCountries
            };
            return userToAdd.Id;    
        }

        public void Edit(UserViewModel user)
        {
            var originalUser = _allUsers.Where(x=> x.Id == user.Id).Single();
            originalUser.Id = user.Id;
            originalUser.FirstName = user.FirstName;
            originalUser.LastName = user.LastName;
            originalUser.VisitedCountries = (IList<TravelDestination>)user.VisitedCountries;
        }

        public void Delete(UserViewModel user)
        {
            var userToDelete = _allUsers.Where(x => x.Id == user.Id).Single();
            _allUsers.Remove(userToDelete);
        } 
    }
}
