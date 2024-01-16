
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SellSwap.Server.Data;
using SellSwap.Shared.Domain;
using SellSwap.Server.IRepository;
using SellSwap.Server.Repository;


namespace SellSwap.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public ListingsController(ApplicationDbContext context)
        public ListingsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Listings
        [HttpGet]
        // public async Task<ActionResult<IEnumerable<listing>>> Getlisting_1()
        public async Task<IActionResult> GetListings()
        {
            ////if (_context.listing_1 == null)
            //{
            //    return NotFound();
            //}
            //return await _context.listing_1.ToListAsync();
            var Listings = await _unitOfWork.Listings.GetAll();
            return Ok(Listings);
        }

        // GET: api/Listings/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<listing>> Getlisting(int id)
        public async Task<IActionResult> Getlisting(int id)
        {
            var listing = await _unitOfWork.Listings.Get(q => q.Id == id);
            //if (_context.listing_1 == null)
            //{
            //    return NotFound();
            //}
            //  var listing = await _context.listing_1.FindAsync(id);

            if (listing == null)
            {
                return NotFound();
            }

            return Ok(listing);
        }

        // PUT: api/Listings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putlisting(int id, Listing listing)

        {
            if (id != listing.Id)
            {
                return BadRequest();
            }

            //_context.Entry(listing).State = EntityState.Modified;
            _unitOfWork.Listings.Update(listing);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await listingExists(id))
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

        // POST: api/Listings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Listing>> Postlisting(Listing listing)
        {
            //if (_context.listing_1 == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.listing_1'  is null.");
            //}
            //_context.listing_1.Add(listing);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Listings.Insert(listing);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Getlisting", new { id = listing.Id }, listing);
        }

        // DELETE: api/Listings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletelisting(int id)
        {
            //if (_context.listing_1 == null)
            //{
            //    return NotFound();
            //}
            //var listing = await _context.listing_1.FindAsync(id);
            var listing = await _unitOfWork.Listings.Get(q => q.Id == id);
            if (listing == null)
            {
                return NotFound();
            }

            //_context.listing_1.Remove(listing);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Listings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool listingExists(int id)
        private async Task<bool> listingExists(int id)
        {
            //return (_context.listing_1?.Any(e => e.Id == id)).GetValueOrDefault();
            var listing = await _unitOfWork.Listings.Get(q => q.Id == id);
            return listing != null;
        }
    }
}

