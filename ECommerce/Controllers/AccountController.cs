using AutoMapper;
using BusinessLogic.Services;
using ECommerce.ViewModel;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly GenericRepository<User> userRepository;
        private readonly AccountRepository accountRepository;

        public AccountController(IMapper _mapper, GenericRepository<User> _userRepository, AccountRepository _accountRepository)
        {
            mapper = _mapper;
            userRepository = _userRepository;
            accountRepository = _accountRepository;
        }
        public IActionResult Registeration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registeration(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = mapper.Map<User>(userViewModel);
                var result = accountRepository.RegisterAsync(user);
                if (result.Result == null)
                    return RedirectToAction("Index", "Home");
                foreach (var error in result.Result)
                    ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(userViewModel);
        }
        public IActionResult LogIn([FromQuery] string ReturnUrl = "~/Home/Index")
        {
            TempData["ReturnUrl"] = ReturnUrl;
            return View();
        }
        [HttpPost]
		public IActionResult LogIn(LoginViewModel loginViewModel)
        {
			var ReturnUrl = TempData["ReturnUrl"].ToString();
			if (ModelState.IsValid)
            {
                var user = mapper.Map<User>(loginViewModel);
                var result = accountRepository.LoginAsync(user);
                if (result.Result == null)
                    return LocalRedirect(ReturnUrl);
                ModelState.AddModelError(string.Empty, result.Result);
            }
            return View(loginViewModel);
        }
        public IActionResult LogOut()
		{
            accountRepository.LogOut();
            return RedirectToAction("Login");
        }
    }
}
