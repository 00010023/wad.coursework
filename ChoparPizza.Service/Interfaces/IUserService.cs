using ChoparPizza.Domain.Commons;
using ChoparPizza.Domain.Configurations;
using ChoparPizza.Domain.Entities.Users;
using ChoparPizza.Service.DTOs.Users;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ChoparPizza.Service.Interfaces
{
    public interface IUserService
    {
        Task<BaseResponse<User>> CreateAsync(UserForCreationDto userDto);
        Task<BaseResponse<User>> GetAsync(Expression<Func<User, bool>> expression);
        Task<BaseResponse<IQueryable<User>>> GetAllAsync(PaginationParams @params, Expression<Func<User, bool>> expression = null);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<User, bool>> expression);
        Task<BaseResponse<User>> UpdateAsync(Guid id, UserForCreationDto userDto);
    }
}
