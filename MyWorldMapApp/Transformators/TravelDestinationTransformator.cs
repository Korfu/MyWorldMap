using MyWorldMapApp.Data;
using MyWorldMapApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
