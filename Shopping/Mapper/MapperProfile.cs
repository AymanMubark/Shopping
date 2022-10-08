using AutoMapper;
using Shopping.DTOs;
using Shopping.Entites;

namespace Shopping.Mapper
{

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Address, AddressResponseDTO>().ReverseMap();
            CreateMap<Order, OrderAddRequestDTO>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailAddRequestDTO>().ReverseMap();
            CreateMap<AppUser, AppUserResponseDTO>().ReverseMap();
            CreateMap<Category, CategoryResponseDTO>().ReverseMap();
            CreateMap<ChoiceCategoryResponseDTO, ChoiceCategory>().ReverseMap();
            CreateMap<ChoiceResponseDTO, Choice>().ReverseMap();
            CreateMap<ProductChoiceReponseDTO, ProductChoice>().ReverseMap();
            CreateMap<ProductImageResponseDTO, ProductImage>().ReverseMap();
            CreateMap<ProductInformationResponseDTO, ProductInformation>().ReverseMap();
            CreateMap<Product, ProductResponseDTO>().ForMember(dest=> dest.ProductChoices,opt=>opt.MapFrom(x=> x.ProductChoices.GroupBy(y => y.Choice.ChoiceCategoryId).Distinct().Select(n => new ChoiceCategoryResponseDTO
            {
                Id = n.Key.Value,
                Name = n.First().Choice.ChoiceCategory.Name,
                Choices = n.Select(x => new ProductChoiceReponseDTO { Id = x.Choice.Id, Name = x.Choice.Name, PriceIncrease = x.PriceIncrease }).ToList(),
            }).ToList())).ReverseMap();
        }
    }
}
