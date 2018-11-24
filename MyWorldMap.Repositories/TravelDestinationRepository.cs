using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyWorldMap.Database;

namespace MyWorldMap.Repositories
{
    class TravelDestinationRepository : ITravelDestinationRepository
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
                Name="Argentyna"
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
