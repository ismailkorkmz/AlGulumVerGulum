using AldimGulumVerdimGulum.Models;
using Entity.POCO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AldimGulumVerdimGulum.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager; 
        }
        [HttpGet]
        public async Task<IActionResult>Login(string ReturnUrl)
        {
            TempData["rtnUrl"] = ReturnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string userName,string password)
        {
            var sign = await signInManager.PasswordSignInAsync(userName, password, false, false);
            if (sign.Succeeded)
            {
                if (TempData["rtnUrl"] != null)
                {
                    return Redirect(TempData["rtnUrl"].ToString());
                }
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    Email = model.Email,
                    UserName = model.UserName
                };
                var identityresult = await userManager.CreateAsync(appUser, model.Password);
                if (!identityresult.Succeeded)
                {
                    foreach (var item in identityresult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(model);
                }
                else
                {
                    await userManager.AddToRoleAsync(appUser, "UserApp");
                }
            }
            return RedirectToAction("Login");
        }
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
    }
}
