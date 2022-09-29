using AutoMapper;
using BusinessLogic.Services;
using ECommerce.ViewModel;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Controllers
{
    public class AdminController : Controller
    {
        private readonly GenericRepository<Category> categoryRepository;
        private readonly GenericRepository<Brand> brandRepository;
        private readonly GenericRepository<Type> typeRepository;
        private readonly GenericRepository<Product> productRepository;
        private readonly GenericRepository<Color> colorRepository;
        private readonly GenericRepository<Image> imageRepository;
        private readonly GenericRepository<Size> sizeRepository;
        private readonly IMapper mapper;

        public AdminController(GenericRepository<Category> _categoryRepository,
             GenericRepository<Product> _productRepository,
             GenericRepository<Brand> _brandRepository,
            GenericRepository<Type> _typeRepository,
            GenericRepository<Color> _colorRepository,
        GenericRepository<Image> _imageRepository,
         GenericRepository<Size> _sizeRepository,
            IMapper _mapper)
        {
            mapper = _mapper;
            typeRepository = _typeRepository;
            productRepository = _productRepository;
            categoryRepository = _categoryRepository;
            brandRepository = _brandRepository;
            colorRepository = _colorRepository;
            imageRepository = _imageRepository; 
            sizeRepository = _sizeRepository;
        }

        public IActionResult CreateProduct()
        {
            ViewData["categories"] = new SelectList(categoryRepository.GetAll(), "Id", "Name");
            ViewData["brands"] = new SelectList(brandRepository.GetAll(), "Id", "Name");
            ViewData["types"] = new SelectList(typeRepository.GetAll(), "Id", "Name");

            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(TypeViewModel typeiewModel)
        {
            if (ModelState.IsValid)
            {
                var type = mapper.Map<Type>(typeiewModel);
                typeRepository.Add(type);
                typeRepository.SaveChanges();
            }
            return View(typeiewModel);
        }




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
