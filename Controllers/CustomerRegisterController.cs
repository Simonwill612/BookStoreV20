using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStoreV10.Data;
using BookStoreV10.Models;

namespace BookStoreV10.Controllers
{
    public class CustomerRegisterController : Controller
    {
        private readonly BookStoreV10Context _context;

        public CustomerRegisterController(BookStoreV10Context context)
        {
            _context = context;
        }       
        public IActionResult Create()
        {
            return View();
        }    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,Password,ImageUrl,Phone,Email,Gender")] Customer customer)
        {
            if (ModelState.IsValid)
            {

                _context.Add(customer);
                await _context.SaveChangesAsync();

                // Redirect to the Login action in the LoginController
                return RedirectToAction("Login", "Login");
            }
            return View(customer);
        }
        private bool CustomerExists(int id)
        {
            return (_context.Customers?.Any(e => e.CustomerId == id)).GetValueOrDefault();
        }
    }
}
