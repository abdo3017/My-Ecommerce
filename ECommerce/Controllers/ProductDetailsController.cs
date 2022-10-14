using AutoMapper;
using BusinessLogic.Services;
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
        private readonly CategoryRepository categoryRepository;
        private readonly ProductRepository productRepository;
        public ProductDetailsController(IMapper _mapper, CategoryRepository _categoryRepository, ProductRepository _productRepository)
        {
            mapper = _mapper;
            categoryRepository = _categoryRepository;
            productRepository = _productRepository;
        }
        public IActionResult Index(int Id,int CatId)
		{
			if (CatId != null)
			{
                var categoryDb=categoryRepository.GetById(CatId);
                var category = mapper.Map<CategoryShopViewModel>(categoryDb);
				ViewData["Category"]=category;
            }
            var productDb = productRepository.GetById(Id);
            var product = mapper.Map<ProductViewModel>(productDb);

            Expression<Func<Product, bool>> predicate =
               e => e.CategoryId == product.CategoryId && e.Id != product.Id;

            var relatedProductsDb = productRepository.GetRelatedProducts(predicate);
            var relatedProducts = mapper.Map<IEnumerable<ProductViewModel>>(relatedProductsDb);
            ViewData["relatedproducts"]= relatedProducts;
            return View(product);
		}
	}
}
