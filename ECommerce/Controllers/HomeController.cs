using AutoMapper;
using BusinessLogic.Services;
using ECommerce.Models;
using ECommerce.ViewModel;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
	//[Authorize]
    public class HomeController : Controller
    {
        private readonly IMapper mapper;
        private readonly GenericRepository<Category> categoryRepository;
        public CategoryHomeViewModel categoryViewModel { get; set; }   
        public HomeController(IMapper _mapper, GenericRepository<Category> _categoryRepository)
        {
            mapper = _mapper;
            categoryRepository = _categoryRepository;
        }

        public IActionResult Index()
        {
            var CategoriesDb=categoryRepository.GetAll();
            var categories = mapper.Map<IEnumerable<CategoryHomeViewModel>>(CategoriesDb);
            for(int i=0;i<CategoriesDb.Count();i++)
            {
                categories.ElementAt(i).ItemCount = CategoriesDb.ElementAt(i).Products.Count();
            } 
            return View(categories);
        }









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View( new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
