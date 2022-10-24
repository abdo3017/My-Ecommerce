using AutoMapper;
using BusinessLogic.Services;
using BusinessLogic.Utils;
using ECommerce.ViewModel;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ECommerce.Controllers
{
    public class ProductDetailsController : Controller
    {
        private readonly IMapper mapper;
        private readonly GenericRepository<Category> categoryRepository;
        private readonly ProductRepository productRepository;
        private readonly GenericRepository<CartItem> shoppingCartRepository;
        private readonly GenericRepository<FavouriteProduct> favouriteProductRepository;

		public ProductDetailsController(IMapper _mapper, GenericRepository<Category> _categoryRepository,
			ProductRepository _productRepository, GenericRepository<CartItem> _shoppingCartRepository,
            GenericRepository<FavouriteProduct> _favouriteProductRepository)
		{
			mapper = _mapper;
			categoryRepository = _categoryRepository;
			productRepository = _productRepository;
			shoppingCartRepository = _shoppingCartRepository;
			favouriteProductRepository = _favouriteProductRepository;
		}
		public IActionResult Index(int Id, int CatId)
        {
            if (CatId != null)
            {
                var categoryDb = categoryRepository.GetById(CatId);
                var category = mapper.Map<CategoryShopViewModel>(categoryDb);
                ViewData["Category"] = category;
            }
            var productDb = productRepository.GetById(Id);
            var product = mapper.Map<ProductViewModel>(productDb);

            Expression<Func<Product, bool>> predicate =
               e => e.CategoryId == product.CategoryId && e.Id != product.Id;

            var relatedProductsDb = productRepository.GetRelatedProducts(predicate);
            var relatedProducts = mapper.Map<IEnumerable<ProductViewModel>>(relatedProductsDb);
            ViewData["relatedproducts"] = relatedProducts;
            return View(product);
        }
        [HttpPost]
        public JsonResult AddToShoppingCart(int productId, int quantity)
        {
            var cartItem = new CartItem();
            cartItem.ProductId = productId;
            cartItem.Quantity = quantity;
            cartItem.UserId = CurrentUser.Instance.user.Id;
            var data = shoppingCartRepository.Add(cartItem);
            try
            {
                shoppingCartRepository.SaveChanges();
            }
            catch (Exception e)
            {
                return Json(false);
            }
            return Json(true);
        }

        public JsonResult AddToFavourite(int productId)
        {
            var item = new FavouriteProduct();
            item.IdProduct = productId;
            item.IdUser = CurrentUser.Instance.user.Id;
            var data = favouriteProductRepository.Add(item);
            try
            {
                favouriteProductRepository.SaveChanges();
            }
            catch (Exception e)
            {
                return Json(false);
            }
            return Json(true);
        }
    }
}
