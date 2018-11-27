using MyWorldMapApp.Data;
using MyWorldMapApp.Dto;
using System.Collections.Generic;

namespace MyWorldMapApp.Repositories
{
    public interface ITravelDestinationRepository
    {
        IEnumerable<TravelDestinationDTO> GetAll();
        TravelDestinationDTO Get(int id);
    }
}
