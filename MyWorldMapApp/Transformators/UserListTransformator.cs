using MyWorldMapApp.Data;
using MyWorldMapApp.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyWorldMapApp.Web.Transformators
{
    public class UserListTransformator
    {
        public static IEnumerable<UserDTO> Map(IEnumerable<User> model)
        {
            var list = model.Select(x => new UserDTO
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

            return list;
        }

        public static IEnumerable<User> Map(IEnumerable<UserDTO> model)
        {
            var list = model.Select(x => new User
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Id = x.Id,
                VisitedCountries = x.VisitedCountries.Select(y => new TravelDestination
                {
                    Id = y.Id,
                    Name = y.Name
                }).ToList()
            });

            return list;
        }

    }
}
