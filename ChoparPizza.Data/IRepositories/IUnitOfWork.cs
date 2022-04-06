using System;
using System.Threading.Tasks;

namespace ChoparPizza.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IOrderRepository Orders { get; }
        IPizzaRepository Pizzas { get; }
        IUserRepository Users { get; }

        Task SaveChangesAsync();
    }
}
