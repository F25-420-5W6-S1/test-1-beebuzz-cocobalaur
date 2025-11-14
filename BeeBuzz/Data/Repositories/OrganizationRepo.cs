using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class OrganizationRepo: BeeBuzzGenericGenericRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepo(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Organization>> logger) : base(db, logger)
        {
        }

        public IEnumerable<Organization> GetAllByUsers(string users)
        {
            return _dbSet.Where(p => p.organizationID == users)
                        .ToList();

        }
    }
}
