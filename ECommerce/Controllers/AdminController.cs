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
        public IActionResult CreateProduct(ProductViewModel productViewModel,
            List<string> selectedColors,
            List<string> selectedSizes)
        {
            if (ModelState.IsValid)
            {
                var product = mapper.Map<Product>(productViewModel);
                var savedProduct = productRepository.AddProduct(product, productViewModel.File);
                productRepository.SaveChanges();

                foreach (var colorname in selectedColors)
                {
                var color = new Color();
                    color.IdProduct = savedProduct.Id;
                    color.Name = colorname; 
                    colorRepository.Add(color);
                    colorRepository.SaveChanges();
                }

                foreach (var sizename in selectedSizes)
                {
                var size = new Size();
                    size.IdProduct = savedProduct.Id;
                    size.Name = sizename;
                    sizeRepository.Add(size);
                    sizeRepository.SaveChanges();
                }
                return View();
            }
            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult UpdateProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = mapper.Map<Product>(productViewModel);
                var savedProduct = productRepository.Update(product);
                productRepository.SaveChanges();
                return View();
            }
            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            var tempProduct = new Product();
            tempProduct.Id = id;
            productRepository.Delete(tempProduct);
            productRepository.SaveChanges();
            return View();
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
        [HttpPost]
        public IActionResult UpdateType(TypeViewModel typeiewModel)
        {
            if (ModelState.IsValid)
            {
                var type = mapper.Map<Type>(typeiewModel);
                typeRepository.Update(type);
                typeRepository.SaveChanges();
            }
            return View(typeiewModel);
        }
        [HttpPost]
        public IActionResult DeleteType(TypeViewModel typeiewModel)
        {
            if (ModelState.IsValid)
            {
                var type = mapper.Map<Type>(typeiewModel);
                typeRepository.Delete(type);
                typeRepository.SaveChanges();
            }
            return View(typeiewModel);
        }
    }
}
