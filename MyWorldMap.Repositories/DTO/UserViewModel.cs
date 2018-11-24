using System.Collections.Generic;

namespace MyWorldMapApp.Repositories
{
    public class UserViewModel 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<TravelDestinationViewModel> VisitedCountries { get; set; }
    }
}
