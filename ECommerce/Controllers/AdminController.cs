using AutoMapper;
using BusinessLogic.Services;
using ECommerce.ViewModel;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ECommerce.Controllers
{
    public class AdminController : Controller
    {
        private readonly GenericRepository<Category> categoryRepository;
        private readonly GenericRepository<Type> typeRepository;
        private readonly ProductRepository productRepository;
        private readonly GenericRepository<Color> colorRepository;
        private readonly GenericRepository<Size> sizeRepository;
        private readonly IMapper mapper;

        public AdminController(GenericRepository<Category> _categoryRepository,
             ProductRepository _productRepository,
            GenericRepository<Type> _typeRepository,
            GenericRepository<Color> _colorRepository,
         GenericRepository<Size> _sizeRepository,
            IMapper _mapper)
        {
            mapper = _mapper;
            typeRepository = _typeRepository;
            productRepository = _productRepository;
            categoryRepository = _categoryRepository;
            colorRepository = _colorRepository;
            sizeRepository = _sizeRepository;
        }

        public IActionResult CreateProduct()
        {
            ViewData["categories"] = new SelectList(categoryRepository.GetAll(), "Id", "Name");
            //ViewData["types"] = new SelectList(typeRepository.GetAll(), "Id", "Name");

            return View();
        }

        [HttpPost]
        public JsonResult GetTypeDataByCategoryId(int categoryId)
        {
            var data = typeRepository.Find(a => a.CategoryId == categoryId);
            var type = mapper.Map<IEnumerable<TypeViewModel>>(data);
            return Json(type);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = mapper.Map<Product>(productViewModel);
                productRepository.AddProduct(product,productViewModel.File);
                typeRepository.SaveChanges();
            }
                return View(productViewModel);
        }
        [HttpPost]
    


        public IActionResult CreateType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateType(TypeViewModel typeiewModel)
        {
            if (ModelState.IsValid)
            {
                var type = mapper.Map<Type>(typeiewModel);
                typeRepository.Add(type);
                typeRepository.SaveChanges();
            }
            return View(typeiewModel);
        }
    }
}
