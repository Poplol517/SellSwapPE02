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
    public class ListingsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ListingsController(IUnitOfWork unitOfWork)
        {
            // _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetListings()
        {
            // return await _context.Categories.ToListAsync();
            var listings = await _unitOfWork.Listings.GetAll(includes: q => q.Include(x => x.ConditionType).Include(x => x.Category).Include(x => x.ListingStatus).Include(x => x.ListingType).Include(x => x.User));
            return Ok(listings);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetListing(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var listing = await _unitOfWork.Listings.Get(q => q.Id == id);

            if (listing == null)
            {
                return NotFound();
            }

            return Ok(listing);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListing(int id, Listing listing)
        {
            if (id != listing.Id)
            {
                return BadRequest();
            }

            //_context.Entry(category).State = EntityState.Modified;
            _unitOfWork.Listings.Update(listing);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!CategoryExists(id))
                if (!await ListingExists(id))
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
        public async Task<ActionResult<Listing>> PostListing(Listing listing)
        {
            //_context.Categories.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Listings.Insert(listing);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetListing", new { id = listing.Id }, listing);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var listing= await _unitOfWork.Listings.Get(q => q.Id == id);
            if (listing == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Listings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> ListingExists(int id)
        {
            // return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
            var listing = await _unitOfWork.Listings.Get(q => q.Id == id);
            return listing != null;
        }
    }
}
