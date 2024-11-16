using Library_management_System.Data;
using Library_management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library_management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public BooksController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await dbContext.Books
                .Include(b=>b.Author)
                .Include(b=>b.Category)
               .ToListAsync();

        }
        [HttpPost]
        public async Task<ActionResult<Book>>GetBook(int id)
        {
            var book = await dbContext.Books
           .Include(b => b.Author)
           .Include(b => b.Category)
           .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }
        
    }
}
