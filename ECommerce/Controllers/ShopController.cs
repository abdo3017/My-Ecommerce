using AutoMapper;
using BusinessLogic.Services;
using ECommerce.ViewModel;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.Controllers
{
    public class ShopController : Controller
    {
        private readonly IMapper mapper;
        private readonly CategoryRepository categoryRepository;
        private readonly ProductRepository productRepository;

        public CategoryHomeViewModel categoryViewModel { get; set; }
        public ProductViewModel productViewModel { get; set; }
        public ShopController(IMapper _mapper, CategoryRepository _categoryRepository, ProductRepository _productRepository)
        {
            mapper = _mapper;
            categoryRepository = _categoryRepository;
            productRepository = _productRepository;
        }
        public IActionResult Index()
        {
            var CategoriesDb = categoryRepository.GetAll();
            var categories = mapper.Map<IEnumerable<CategoryShopViewModel>>(CategoriesDb);
            IEnumerable<Product> productsDb;
            if (TempData["catId"] != null)
            {
                ViewData["catId"] = TempData["catId"];
                productsDb = productRepository.GetByCategory((int)TempData["catId"]);
            }
            else
                productsDb = productRepository.GetAll();

            var products = mapper.Map<IEnumerable<ProductViewModel>>(productsDb);
            ViewData["products"] = products;
            return View(categories);
        }
        public IActionResult GetProductsOfCategory(int id)
        {
            TempData["catId"] = id;
            return RedirectToAction("Index");
        }
        public JsonResult GetProductsOfType(int categoryId, int typeId)
        {
            var productsDb = productRepository.GetByType(categoryId, typeId);
            var products = mapper.Map<IEnumerable<ProductViewModel>>(productsDb);
            ViewData["products"] = products;
            return Json(products);
        }

    }
}
