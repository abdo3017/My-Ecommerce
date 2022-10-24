using AutoMapper;
using BusinessLogic.Services;
using BusinessLogic.Utils;
using ECommerce.ViewModel;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ECommerce.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMapper mapper;
        private readonly GenericRepository<CartItem> shoppingCartRepository;
        public ShoppingCartController(IMapper _mapper, GenericRepository<CartItem> _shoppingCartRepository)
        {
            mapper = _mapper;
            shoppingCartRepository = _shoppingCartRepository;
        }
        public IActionResult Index()
        {
            var itemsDb = shoppingCartRepository.Find(p => p.UserId == CurrentUser.Instance.user.Id);
            var items = mapper.Map<IEnumerable<CartItemViewModel>>(itemsDb);
            ViewData["userId"] = CurrentUser.Instance.user.Id;
            return View(items);
        }
        public JsonResult RemoveFromShoppingCart(int productId)
        {
            var item = new CartItem();
            item.ProductId = productId;
            item.UserId = CurrentUser.Instance.user.Id;
            var data = shoppingCartRepository.Delete(item);
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
    }
}
