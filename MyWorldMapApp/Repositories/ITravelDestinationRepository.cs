using MyWorldMapApp.Data;
using System.Collections.Generic;

namespace MyWorldMapApp.Repositories
{
    public interface ITravelDestinationRepository
    {
        List<TravelDestination> GetAll();
        TravelDestination Get(int id);
    }
}
