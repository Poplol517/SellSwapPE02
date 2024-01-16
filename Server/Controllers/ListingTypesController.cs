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
    public class ListingTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ListingTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ListingTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListingType>>> GetListingType()
        {
          if (_context.ListingType == null)
          {
              return NotFound();
          }
            return await _context.ListingType.ToListAsync();
        }

        // GET: api/ListingTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListingType>> GetListingType(int id)
        {
          if (_context.ListingType == null)
          {
              return NotFound();
          }
            var listingType = await _context.ListingType.FindAsync(id);

            if (listingType == null)
            {
                return NotFound();
            }

            return listingType;
        }

        // PUT: api/ListingTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListingType(int id, ListingType listingType)
        {
            if (id != listingType.Id)
            {
                return BadRequest();
            }

            _context.Entry(listingType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListingTypeExists(id))
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

        // POST: api/ListingTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ListingType>> PostListingType(ListingType listingType)
        {
          if (_context.ListingType == null)
          {
              return Problem("Entity set 'ApplicationDbContext.ListingType'  is null.");
          }
            _context.ListingType.Add(listingType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListingType", new { id = listingType.Id }, listingType);
        }

        // DELETE: api/ListingTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListingType(int id)
        {
            if (_context.ListingType == null)
            {
                return NotFound();
            }
            var listingType = await _context.ListingType.FindAsync(id);
            if (listingType == null)
            {
                return NotFound();
            }

            _context.ListingType.Remove(listingType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListingTypeExists(int id)
        {
            return (_context.ListingType?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
