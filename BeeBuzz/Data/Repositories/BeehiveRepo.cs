using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class BeehiveRepo: BeeBuzzGenericGenericRepository<Organization>,// IBeeBuzzGenericRepository
    {
        public BeehiveRepo(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Beehive>> logger) : base(db, logger)
        {

        }

        public IEnumerable<Beehive> GetAllByUsers(string users)
        {
            return _dbSet.Where(p => p.users == users)
                        .ToList();



        }
    }
}
