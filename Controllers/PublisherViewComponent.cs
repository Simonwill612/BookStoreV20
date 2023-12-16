using BookStoreV10.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks; // Add this namespace for Task and ToListAsync

namespace BookStoreV10.Controllers
{
    [ViewComponent(Name = "Publisher")]
    public class PublisherViewComponent : ViewComponent
    {
        private readonly BookStoreV10Context _context;

        public PublisherViewComponent(BookStoreV10Context context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var publishers = await _context.Publisher.ToListAsync();
            return View("Publisher", publishers);
        }
    }
}
