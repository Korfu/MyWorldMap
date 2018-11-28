using MyWorldMapApp.Dto;
using MyWorldMapApp.Web.Data;
using MyWorldMapApp.Web.DTO;
using System.Linq;

namespace MyWorldMapApp.Web.Transformators
{
    public class UserTransformator
    {
        public static UserDTO Map(User model)
        {
            var result = new UserDTO()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Id = model.Id,
                VisitedCountries = model.VisitedCountries.Select(y => new TravelDestinationDTO
                {
                    Id = y.Id,
                    Name = y.Name
                })
            };

            return result;
        }

        public static User Map(UserDTO model)
        {
            var result = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Id = model.Id,
                VisitedCountries = model.VisitedCountries.Select(y => new TravelDestination
                {
                    Id = y.Id,
                    Name = y.Name
                })
            };

            return result;
        }
    }
}
