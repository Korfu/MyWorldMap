
using MyWorldMapApp.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyWorldMapApp.Web.Repositories
{
    public class TravelDestinationRepository : ITravelDestinationRepository
    {
        private List<TravelDestination> _allTravelDestinations = new List<TravelDestination>
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
            }
        };

        public TravelDestination Get(int id)
        {
            return _allTravelDestinations.First(x =>x.Id == id);        }

        public List<TravelDestination> GetAll()
        {
            return _allTravelDestinations;
        }
    }
}
