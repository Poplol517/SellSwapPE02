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
    public class OffersController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public OffersController(IUnitOfWork unitOfWork)
        {
            // _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetOffers()
        {
            // return await _context.Categories.ToListAsync();
            var offers = await _unitOfWork.Offers.GetAll(includes: q => q.Include(x => x.Listing).Include(x => x.Account).Include(x => x.Listing.ListingType));
            return Ok(offers);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetOffer(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var offer = await _unitOfWork.Offers.Get(q => q.Id == id);

            if (offer == null)
            {
                return NotFound();
            }

            return Ok(offer);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOffer(int id, Offer offer)
        {
            if (id != offer.Id)
            {
                return BadRequest();
            }

            //_context.Entry(category).State = EntityState.Modified;
            _unitOfWork.Offers.Update(offer);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!CategoryExists(id))
                if (!await OfferExists(id))
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
        public async Task<ActionResult<Category>> PostOffer(Offer offer)
        {
            //_context.Categories.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Offers.Insert(offer);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetOffers", new { id = offer.Id }, offer);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffer(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var offer = await _unitOfWork.Offers.Get(q => q.Id == id);
            if (offer == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Offers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> OfferExists(int id)
        {
            // return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
            var offer = await _unitOfWork.Offers.Get(q => q.Id == id);
            return offer != null;
        }
    }
}
