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
    public class ListingStatusController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ListingStatusController(IUnitOfWork unitOfWork)
        {
            // _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetListingStatus()
        {
            // return await _context.Categories.ToListAsync();
            var listingstatus = await _unitOfWork.ListingStatus.GetAll();
            return Ok(listingstatus);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetListingStatus(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var listingstatus = await _unitOfWork.ListingStatus.Get(q => q.Id == id);

            if (listingstatus == null)
            {
                return NotFound();
            }

            return Ok(listingstatus);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putlistingstatus(int id, ListingStatus listingstatus)
        {
            if (id != listingstatus.Id)
            {
                return BadRequest();
            }

            //_context.Entry(category).State = EntityState.Modified;
            _unitOfWork.ListingStatus.Update(listingstatus);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!CategoryExists(id))
                if (!await ListingStatusExists(id))
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
        public async Task<ActionResult<ListingStatus>> PostListingStatus(ListingStatus listingstatus)
        {
            //_context.Categories.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ListingStatus.Insert(listingstatus);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetListingstatus", new { id = listingstatus.Id }, listingstatus);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListingStatus(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var listingstatus = await _unitOfWork.ListingStatus.Get(q => q.Id == id);
            if (listingstatus == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ListingStatus.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> ListingStatusExists(int id)
        {
            // return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
            var listingStatus = await _unitOfWork.ListingStatus.Get(q => q.Id == id);
            return listingStatus != null;
        }
    }
}