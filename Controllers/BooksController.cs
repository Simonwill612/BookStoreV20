using BookStoreV10.Models;
using BookStoreV10.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace BookStoreV10.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookStoreV10Context _context;

        public BooksController(BookStoreV10Context context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var BookStoreV10Context = _context.Book.Include(b => b.Author).Include(b => b.Publisher).Include(b => b.StoreOwner);
            return View(await BookStoreV10Context.ToListAsync());
        }
        // GET: Books/Details/5
        public async Task<IActionResult> BookDetail(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.StoreOwner)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.StoreOwner)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorName");
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "PublisherId", "PublisherName");
            ViewData["StoreOwnerId"] = new SelectList(_context.Set<StoreOwner>(), "StoreOwnerId", "StoreOwnerId");

            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,Image,Title,Describe,Price,AuthorId,PublisherId,StoreOwnerId")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId", book.AuthorId);
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "PublisherId", "PublisherId", book.PublisherId);
            ViewData["StoreOwnerId"] = new SelectList(_context.Set<StoreOwner>(), "StoreOwnerId", "StoreOwnerId", book.StoreOwnerId);

            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorName", book.AuthorId);
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "PublisherId", "PublisherName", book.PublisherId);
            ViewData["StoreOwnerId"] = new SelectList(_context.Set<StoreOwner>(), "StoreOwnerId", "StoreOwnerId", book.StoreOwnerId);

            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookId,Image,Title,Describe,Price,AuthorId,PublisherId,StoreOwnerId")] Book book)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId", book.AuthorId);
            ViewData["PublisherId"] = new SelectList(_context.Publisher, "PublisherId", "PublisherId", book.PublisherId);
            ViewData["StoreOwnerId"] = new SelectList(_context.Set<StoreOwner>(), "StoreOwnerId", "StoreOwnerId", book.StoreOwnerId);

            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.StoreOwner)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (_context.Book == null)
            {
                return Problem("Entity set  is null.");
            }
            var book = await _context.Book.FindAsync(id);
            if (book != null)
            {
                _context.Book.Remove(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool BookExists(int id)
        {
            return (_context.Book?.Any(e => e.BookId == id)).GetValueOrDefault();
        }
    }
}