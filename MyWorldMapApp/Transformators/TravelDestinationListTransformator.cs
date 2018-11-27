using MyWorldMapApp.Data;
using MyWorldMapApp.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MyWorldMapApp.Web.Transformators
{
    public class TravelDestinationListTransformator
    {
        public static IEnumerable<TravelDestinationDTO> Map(IEnumerable<TravelDestination> model)
        {
            var list = model.Select(x => new TravelDestinationDTO
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return list;
        }

        public static IEnumerable<TravelDestination> Map(IEnumerable<TravelDestinationDTO> model)
        {
            var list = model.Select(x => new TravelDestination
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return list;
        }
    }
}
