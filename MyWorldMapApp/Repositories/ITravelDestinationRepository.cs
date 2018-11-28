using MyWorldMapApp.Web.DTO;
using System.Collections.Generic;

namespace MyWorldMapApp.Web.Repositories
{
    public interface ITravelDestinationRepository
    {
        IEnumerable<TravelDestinationDTO> GetAll();
        TravelDestinationDTO Get(int id);
    }
}
