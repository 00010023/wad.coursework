using ChoparPizza.Data.Contexts;
using ChoparPizza.Data.IRepositories;
using ChoparPizza.Domain.Entities.Orders;
using Serilog;

namespace ChoparPizza.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(BellisimoDbContext context, ILogger logger) : base(context, logger)
        {
        }

    }
}
