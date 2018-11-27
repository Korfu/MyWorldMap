using MyWorldMapApp.Data;
using MyWorldMapApp.Dto;
using MyWorldMapApp.Web.Transformators;
using System.Collections.Generic;
using System.Linq;

namespace MyWorldMapApp.Repositories
{
    public class TravelDestinationRepositoryMock : ITravelDestinationRepository
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

        public TravelDestinationDTO Get(int id)
        {
            var result = _allTravelDestinations.First(x => x.Id == id);
            return TravelDestinationTransformator.Map(result);
        }

        public IEnumerable<TravelDestinationDTO> GetAll()
        {
            return TravelDestinationListTransformator.Map(_allTravelDestinations);
        }
    }
}
