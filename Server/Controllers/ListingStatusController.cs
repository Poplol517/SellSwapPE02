using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SellSwap.Server.Data;
using SellSwap.Shared.Domain;

namespace SellSwap.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingStatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ListingStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ListingStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListingStatus>>> GetListingStatus()
        {
          if (_context.ListingStatus == null)
          {
              return NotFound();
          }
            return await _context.ListingStatus.ToListAsync();
        }

        // GET: api/ListingStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListingStatus>> GetListingStatus(int id)
        {
          if (_context.ListingStatus == null)
          {
              return NotFound();
          }
            var listingStatus = await _context.ListingStatus.FindAsync(id);

            if (listingStatus == null)
            {
                return NotFound();
            }

            return listingStatus;
        }

        // PUT: api/ListingStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListingStatus(int id, ListingStatus listingStatus)
        {
            if (id != listingStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(listingStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListingStatusExists(id))
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

        // POST: api/ListingStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ListingStatus>> PostListingStatus(ListingStatus listingStatus)
        {
          if (_context.ListingStatus == null)
          {
              return Problem("Entity set 'ApplicationDbContext.ListingStatus'  is null.");
          }
            _context.ListingStatus.Add(listingStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListingStatus", new { id = listingStatus.Id }, listingStatus);
        }

        // DELETE: api/ListingStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListingStatus(int id)
        {
            if (_context.ListingStatus == null)
            {
                return NotFound();
            }
            var listingStatus = await _context.ListingStatus.FindAsync(id);
            if (listingStatus == null)
            {
                return NotFound();
            }

            _context.ListingStatus.Remove(listingStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListingStatusExists(int id)
        {
            return (_context.ListingStatus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
