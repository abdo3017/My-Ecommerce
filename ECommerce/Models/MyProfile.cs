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
		}
	}
}
