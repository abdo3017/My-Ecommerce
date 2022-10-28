using AutoMapper;
using BusinessLogic.Services;
using BusinessLogic.Utils;
using ECommerce.ViewModel;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ECommerce.Controllers
{
    public class FavouriteProductsController : Controller
    {
        private readonly IMapper mapper;
        private readonly FavouriteProductRepository favouriteProductRepository;
        public FavouriteProductsController(IMapper _mapper,
            FavouriteProductRepository _favouriteProductRepository)
        {
            mapper = _mapper;
            favouriteProductRepository = _favouriteProductRepository;
        }
        public IActionResult Index()
        {
            var itemsDb = favouriteProductRepository.Find(p => p.IdUser == CurrentUser.Instance.user.Id);
            if (itemsDb.ToList().Count > 0)
            {
                var items = mapper.Map<IEnumerable<FavouriteProductViewModel>>(itemsDb);
                ViewData["userId"] = CurrentUser.Instance.user.Id;
                return View(items);
            }
            return View("EmptyFavourite");
        }

        public IActionResult RemoveAllFromFavouritePage()
        {
            Expression<Func<FavouriteProduct, bool>> predicate =
                p => p.IdUser == CurrentUser.Instance.user.Id;
            favouriteProductRepository.Delete(predicate);
            try
            {
                favouriteProductRepository.SaveChanges();
            }
            catch (Exception e)
            {
                return Json(false);
            }
            return View("EmptyFavourite");
        }
        public JsonResult RemoveFromFavouritePage(int productId)
        {
            var item = new FavouriteProduct();
            item.IdProduct = productId;
            item.IdUser = CurrentUser.Instance.user.Id;
            var data = favouriteProductRepository.Delete(item);
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
