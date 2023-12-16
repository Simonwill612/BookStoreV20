using BookStoreV10.Data;
using BookStoreV10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging; // Added for ILogger
using System.Diagnostics;
using System.Threading.Tasks;

namespace BookStoreV10.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookStoreV10Context _context;
        private readonly ILogger<HomeController> _logger; // Added ILogger

        // Combine the constructors into one
        public HomeController(BookStoreV10Context context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        
        public async Task<IActionResult> Index()
        {
            var books = await _context.Book.Include(b => b.StoreOwner).ToListAsync();
            return View(books);
        }

        public IActionResult Privacy()
        {
            return View();
        }
 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
