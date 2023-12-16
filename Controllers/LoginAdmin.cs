using BookStoreV10.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using BookStoreV10.Data;

namespace BookStoreV10.Controllers
{
    public class LoginAdmin : Controller
    {
        private readonly BookStoreV10Context _context;

        public LoginAdmin(BookStoreV10Context context)
        {
            _context = context;
        }

        public IActionResult LoginAdmins()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginAdmins(Admin _adminFromPage)
        {
            var _admin = _context.Admin.Where(m => m.Name == _adminFromPage.Name && m.Password == _adminFromPage.Password).FirstOrDefault();
            if (_admin == null)
            {
                ViewBag.LoginAdminStatus = 0;
            }
            else
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name,_admin.Name),
            new Claim("Password", _admin.Password),
        };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {

                };

                HttpContext.SignInAsync(
                   CookieAuthenticationDefaults.AuthenticationScheme,
                   new ClaimsPrincipal(claimsIdentity),
                   authProperties);
                return RedirectToAction("Index", "Adm");
            }
            return View();
        }
    }
}
