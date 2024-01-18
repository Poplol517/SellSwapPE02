using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SellSwap.Server.Data;
using SellSwap.Server.IRepository;
using SellSwap.Shared.Domain;

namespace SellSwap.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouritesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public FavouritesController(IUnitOfWork unitOfWork)
        {
            // _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetFavourites()
        {
            // return await _context.Categories.ToListAsync();
            var favourites = await _unitOfWork.Favourites.GetAll(includes: q => q.Include(x => x.Listing).Include(x => x.Account));
            return Ok(favourites); 
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetFavourite(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var favourite = await _unitOfWork.Favourites.Get(q => q.Id == id);

            if (favourite == null)
            {
                return NotFound();
            }

            return Ok(favourite);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavourite(int id, Favourite favorite)
        {
            if (id != favorite.Id)
            {
                return BadRequest();
            }

            //_context.Entry(category).State = EntityState.Modified;
            _unitOfWork.Favourites.Update(favorite);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!CategoryExists(id))
                if (!await FavouriteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category>> PostFavourite(Favourite favourite)
        {
            //_context.Categories.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Favourites.Insert(favourite);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetFavourite", new { id = favourite.Id }, favourite);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavourite(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var favourite = await _unitOfWork.Favourites.Get(q => q.Id == id);
            if (favourite == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Favourites.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> FavouriteExists(int id)
        {
            // return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
            var favourite= await _unitOfWork.Favourites.Get(q => q.Id == id);
            return favourite != null;
        }
    }
}
