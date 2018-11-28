using MyWorldMapApp.Web.Data;
using System.Collections.Generic;

namespace MyWorldMapApp.Web.Repositories
{
    public interface ITravelDestinationRepository
    {
        List<TravelDestination> GetAll();
        TravelDestination Get(int id);
    }
}
