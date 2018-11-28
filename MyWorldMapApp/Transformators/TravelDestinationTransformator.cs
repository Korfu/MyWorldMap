using MyWorldMapApp.Web.Data;
using MyWorldMapApp.Web.DTO;

namespace MyWorldMapApp.Web.Transformators
{
    public class TravelDestinationTransformator
    {
        public static TravelDestinationDTO Map(TravelDestination model)
        {
            var result = new TravelDestinationDTO()
            {
                Id = model.Id,
                Name = model.Name
            };
            return result;
        }

        public static TravelDestination Map(TravelDestinationDTO model)
        {
            var result = new TravelDestination()
            {
                Id = model.Id,
                Name = model.Name
            };
            return result;
        }
    }
}
