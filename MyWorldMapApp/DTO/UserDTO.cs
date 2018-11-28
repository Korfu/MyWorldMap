using System.Collections.Generic;

namespace MyWorldMapApp.Web.Repositories
{
    public class UserDTO 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<TravelDestinationDTO> VisitedCountries { get; set; }
    }
}
