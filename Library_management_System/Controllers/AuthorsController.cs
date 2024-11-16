using Library_management_System.Data;
using Library_management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library_management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public AuthorsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return await dbContext.Authors.ToListAsync();

        }
        [HttpPost]
        public async Task<ActionResult<Author>> PostAuthor(Author author)
        {
            dbContext.Authors.Add(author);
            await dbContext.SaveChangesAsync();
            return CreatedAtAction("GetAuthor", new {id=author.Id},author);
        }
    }
}
