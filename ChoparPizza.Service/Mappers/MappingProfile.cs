using AutoMapper;
using ChoparPizza.Domain.Entities.Orders;
using ChoparPizza.Domain.Entities.Pizzas;
using ChoparPizza.Domain.Entities.Users;
using ChoparPizza.Service.DTOs.Orders;
using ChoparPizza.Service.DTOs.Pizzas;
using ChoparPizza.Service.DTOs.Users;

namespace ChoparPizza.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PizzaForCreationDto, Pizza>().ReverseMap();
            CreateMap<OrderForCreationDto, Order>().ReverseMap();
            CreateMap<UserForCreationDto, User>().ReverseMap();

        }
    }
}
