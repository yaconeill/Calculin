using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using CambioMonedaWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ModeloCore;
using RepositorioCore;

namespace CambioMonedaWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UsuarioConversor> userManager;
        private readonly SignInManager<UsuarioConversor> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public IRepositorio _repositorio { get; set; }

        public AccountController(UserManager<UsuarioConversor> userManager,
            SignInManager<UsuarioConversor> signInManager, 
            RoleManager<IdentityRole> roleManager, IRepositorio repositorio)
        {
            _repositorio = repositorio;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        private Task<UsuarioConversor> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);
        //var user = await GetCurrentUserAsync();
        [HttpGet]
        public IActionResult Register()
        {
            var registerViewModel = new RegisterViewModel
            {
                Paises = _repositorio.ObtenerPaises()
            };
            return View(registerViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Error");

            var user = new UsuarioConversor()
            {
                UserName = model.Email,
                Email = model.Email,
                FechaNacimiento = model.FechaNacimiento,
                IdPais = model.IdPais
            };

            var result = await userManager.CreateAsync(
                user, model.Password);

            if (!await roleManager.RoleExistsAsync("Organizer"))
                await roleManager.CreateAsync(new IdentityRole { Name = "Organizer" });
            if (!await roleManager.RoleExistsAsync("Speaker"))
                await roleManager.CreateAsync(new IdentityRole { Name = "Speaker" });

            if (result.Succeeded)
                return View("Login");

            foreach (var error in result.Errors)
                ModelState.AddModelError("error", error.Description);
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await
                        signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,
                            lockoutOnFailure: false);
                if (result.Succeeded)
                    return RedirectToAction("VerConversor", "Home");
                if (result.IsLockedOut)
                {
                    return View("Lockout");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);

            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> LogOff()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

    }
}