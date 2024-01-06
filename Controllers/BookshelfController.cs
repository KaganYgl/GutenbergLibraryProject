using gutenberg.Data;
using gutenberg.Models;
using Microsoft.AspNetCore.Mvc;

namespace gutenberg.Controllers
{
    public class BookshelfController : Controller
    {
        private readonly BookshelfDbContext _context;

        public BookshelfController(BookshelfDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bookshelfItems = _context.BookshelfItems.ToList();
            return View(bookshelfItems);
        }

        [HttpPost]
        public IActionResult AddToBookshelf(int bookId, string bookTitle, string bookAuthor, string readLink)
        {
            // Check if the book already exists in the bookshelf
            var existingBook = _context.BookshelfItems
                .FirstOrDefault(b => b.GutenbergID == bookId);

            if (existingBook != null)
            {
                // Book already exists, you can handle this case (e.g., show a message)
                // For now, let's redirect to the Bookshelf
                return RedirectToAction("Index", "Bookshelf");
            }

            var book = new BookshelfItem
            {
                GutenbergID = bookId,
                Title = bookTitle,
                Author = bookAuthor,
                ReadLink = readLink,
            };

            _context.BookshelfItems.Add(book);
            _context.SaveChanges();

            return RedirectToAction("Index", "Bookshelf");
        }

        [HttpPost]
        public IActionResult RemoveFromBookshelf(int bookId)
        {
            try
            {
                var bookToRemove = _context.BookshelfItems.Find(bookId);

                if (bookToRemove != null)
                {
                    _context.BookshelfItems.Remove(bookToRemove);
                    _context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // Log the exception or print it for debugging
                Console.WriteLine($"Exception: {ex.Message}");
                return View("Error");
            }
        }
    }

}
