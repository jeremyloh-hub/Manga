using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class MangasController : BaseApiController
    {
        private readonly DataContext _context;

        public MangasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] //api/mangas
        public async Task<ActionResult<List<Manga>>> GetMangas()
        {
            return await _context.Mangas.ToListAsync();
        }

        [HttpGet("{id}")] //api/mangas/:id
        public async Task<ActionResult<Manga>> GetManga(Guid id)
        {
            return await _context.Mangas.FindAsync(id);
        }
    }
}
