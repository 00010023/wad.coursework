using ChoparPizza.Data.Contexts;
using ChoparPizza.Data.IRepositories;
using ChoparPizza.Domain.Entities.Users;
using Serilog;

namespace ChoparPizza.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(BellisimoDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
