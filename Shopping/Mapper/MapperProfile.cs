using AutoMapper;
using Shopping.DTOs;
using Shopping.Entites;
using Shopping.Entites.Enums;

namespace Shopping.Mapper
{

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Order, OrderResponseDTO>().ForMember(dest => dest.Status, opt => opt.MapFrom(x => (OrderStatus)x.Status)).ReverseMap();
            CreateMap<OrderDetail, OrderDetailResponseDTO>().ReverseMap();
            CreateMap<Address, AddressResponseDTO>().ReverseMap();
            CreateMap<Order, OrderAddRequestDTO>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailAddRequestDTO>().ReverseMap();
            CreateMap<AppUser, AppUserResponseDTO>().ReverseMap();
            CreateMap<Category, CategoryResponseDTO>().ForMember(dest=> dest.Count , opt=>opt.MapFrom(x=>x.SubCategories.Count())).ReverseMap();
            CreateMap<ChoiceCategoryResponseDTO, ChoiceCategory>().ReverseMap();
            CreateMap<ChoiceResponseDTO, Choice>().ReverseMap();
            CreateMap<ProductChoiceReponseDTO, ProductChoice>().ReverseMap();
            CreateMap<ProductImageResponseDTO, ProductImage>().ReverseMap();
            CreateMap<ProductInformationResponseDTO, ProductInformation>().ReverseMap();
            CreateMap<Product, ProductResponseDTO>().ReverseMap();
            CreateMap<Choice, ProductChoiceReponseDTO>().ReverseMap();
        }
    }
}
