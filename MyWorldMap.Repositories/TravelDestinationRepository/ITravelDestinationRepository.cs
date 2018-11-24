using MyWorldMap.Database;
using System.Collections.Generic;

namespace MyWorldMap.Repositories
{
    public interface ITravelDestinationRepository
    {
        List<TravelDestination> GetAll();
        TravelDestination Get(int id);
    }
}
