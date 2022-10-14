using BusinessLogic.Utils;
using InfraStructure.Database;
using InfraStructure.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class AccountRepository
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly GenericRepository<User> userRpository;
        private readonly MyDbContext context;


        public AccountRepository(GenericRepository<User> _userRpository, UserManager<IdentityUser> _userManager, SignInManager<IdentityUser> _signInManager, RoleManager<IdentityRole> _RoleManager, MyDbContext _context)
        {
            userRpository = _userRpository;
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _RoleManager;
            context = _context;
        }



        public async Task<IEnumerable<IdentityError>> RegisterAsync(User user)
        {

            var identity = new IdentityUser();
            identity.Email = user.Email;
            identity.UserName = user.Name;
            IdentityResult result = await userManager.CreateAsync(identity, user.Password);
            if (result.Succeeded)
            {
                user.Id = identity.Id;
                userRpository.Add(user);
                userRpository.SaveChanges();
                setCurrentUser(user);
                //await userManager.AddToRoleAsync(identity, "Client");
                //create cookie for registeration
                await signInManager.SignInAsync(identity, user.RememberMe);
                return null;
            }
            return result.Errors;
        }
        public async Task<string> LoginAsync(User user)
        {
            IdentityUser identity = await userManager.FindByEmailAsync(user.Email);
            if (identity != null)
            {
                var result = await signInManager.PasswordSignInAsync(identity, user.Password, user.RememberMe, false);
                if (result.Succeeded)
                {
                    var item = userRpository.FindOne(u => u.Id == identity.Id);
                    setCurrentUser(item);
                    return null;
                }
                return "invalid  Password";
            }
            return "invalid Email ";
        }
        public async void LogOut()
        {
            await signInManager.SignOutAsync();
        }
        private void setCurrentUser(User user)
        {
            CurrentUser.Instance.user = new Domain.Models.User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                RememberMe = user.RememberMe
            };
        }
    }
}
