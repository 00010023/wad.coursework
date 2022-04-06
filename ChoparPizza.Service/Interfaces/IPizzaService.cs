using ChoparPizza.Domain.Commons;
using ChoparPizza.Domain.Configurations;
using ChoparPizza.Domain.Entities.Pizzas;
using ChoparPizza.Service.DTOs.Pizzas;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ChoparPizza.Service.Interfaces
{
    public interface IPizzaService
    {
        Task<BaseResponse<Pizza>> CreateAsync(PizzaForCreationDto pizzaDto);
        Task<BaseResponse<Pizza>> GetAsync(Expression<Func<Pizza, bool>> expression);
        Task<BaseResponse<IQueryable<Pizza>>> GetAllAsync(PaginationParams @params, Expression<Func<Pizza, bool>> expression = null);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Pizza, bool>> expression);
        Task<BaseResponse<Pizza>> UpdateAsync(Guid id, PizzaForCreationDto pizzaDto);

    }
}
