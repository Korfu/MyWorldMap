using MyWorldMapApp.Web.DTO;
using System.Collections.Generic;

namespace MyWorldMapApp.Dto
{
    public class UserDTO 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<TravelDestinationDTO> VisitedCountries { get; set; }
    }
}
