using AutoMapper;
using ECommerce.ViewModel;
using InfraStructure.Entity;

namespace ECommerce.Models
{
	public class MyProfile : Profile
	{
		public MyProfile()
		{
			CreateMap<UserViewModel, User>();
			CreateMap<LoginViewModel, User>();

			CreateMap<TypeViewModel, Type>();
			CreateMap<Type, TypeViewModel>();

			CreateMap<ProductViewModel, Product>();
			CreateMap<Product, ProductViewModel>();

			CreateMap<Category, CategoryHomeViewModel>();
			CreateMap<CategoryHomeViewModel, Category>();

			CreateMap<Category, CategoryShopViewModel>();
			CreateMap<CategoryShopViewModel, Category>();

			CreateMap<Size, Domain.Models.Size>();
			CreateMap<Domain.Models.Size, Size>();

			CreateMap<Color, Domain.Models.Color>();
			CreateMap<Domain.Models.Color, Color>();

			CreateMap<CartItem, CartItemViewModel>();
			CreateMap<CartItemViewModel, CartItem>();

			CreateMap<FavouriteProduct, FavouriteProductViewModel>();
			CreateMap<FavouriteProductViewModel, FavouriteProduct>();
		}
	}
}
