using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Repositories;

namespace BeeBuzz.Data.Interfaces
{
    public interface IOrganizationRepository : IBeeBuzzGenericRepository<Organization>
    {
        IEnumerable<Organization> GetAllByUsers(string users);
    }
}
