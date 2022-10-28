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
    public class ShoppingCartController : Controller
    {
        private readonly IMapper mapper;
        private readonly CartProductRepository shoppingCartRepository;
        public ShoppingCartController(IMapper _mapper, CartProductRepository _shoppingCartRepository)
        {
            mapper = _mapper;
            shoppingCartRepository = _shoppingCartRepository;
        }
        public IActionResult Index()
        {
            var itemsDb = shoppingCartRepository.Find(p => p.UserId == CurrentUser.Instance.user.Id);
            if (itemsDb.ToList().Count > 0)
            {
                var items = mapper.Map<IEnumerable<CartItemViewModel>>(itemsDb);
                ViewData["userId"] = CurrentUser.Instance.user.Id;
                return View(items);
            }
            return View("EmptyCart");
        }
        public IActionResult RemoveAllFromShoppingCart()
        {
            Expression<Func<CartItem, bool>> predicate =
                p => p.UserId == CurrentUser.Instance.user.Id;
            shoppingCartRepository.Delete(predicate);
            try
            {
                shoppingCartRepository.SaveChanges();
            }
            catch (Exception e)
            {
                return Json(false);
            }
            return View("EmptyCart");
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
        public JsonResult UpdateShoppingCart(int productId, int productQuantity)
        {
            var item = new CartItem();
            item.ProductId = productId;
            item.UserId = CurrentUser.Instance.user.Id;
            item.Quantity = productQuantity;
            var data = shoppingCartRepository.Update(item);
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
