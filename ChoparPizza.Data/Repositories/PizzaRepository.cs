using ChoparPizza.Data.Contexts;
using ChoparPizza.Data.IRepositories;
using ChoparPizza.Domain.Entities.Pizzas;
using Serilog;

namespace ChoparPizza.Data.Repositories
{
    public class PizzaRepository : GenericRepository<Pizza>, IPizzaRepository
    {
        public PizzaRepository(BellisimoDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
