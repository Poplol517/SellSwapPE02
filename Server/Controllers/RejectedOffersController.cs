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
    public class RejectedOffersController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public RejectedOffersController(IUnitOfWork unitOfWork)
        {
            // _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetRejectedOffers()
        {
            // return await _context.Categories.ToListAsync();
            var rejectedoffers = await _unitOfWork.RejectedOffers.GetAll(includes: q => q.Include(x => x.Offer).Include(x => x.Account));
            return Ok(rejectedoffers);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetRejectedOffer(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var rejectedoffer = await _unitOfWork.RejectedOffers.Get(q => q.Id == id);

            if (rejectedoffer == null)
            {
                return NotFound();
            }

            return Ok(rejectedoffer);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRejectedOffer(int id, RejectedOffer rejectedoffer)
        {
            if (id != rejectedoffer.Id)
            {
                return BadRequest();
            }

            //_context.Entry(category).State = EntityState.Modified;
            _unitOfWork.RejectedOffers.Update(rejectedoffer);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!CategoryExists(id))
                if (!await RejectedOfferExists(id))
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
        public async Task<ActionResult<RejectedOffer>> PostRejectedOffer(RejectedOffer rejectedoffer)
        {
            //_context.Categories.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RejectedOffers.Insert(rejectedoffer);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetOffers", new { id = rejectedoffer.Id }, rejectedoffer);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRejectedOffer(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var rejectedoffer = await _unitOfWork.RejectedOffers.Get(q => q.Id == id);
            if (rejectedoffer == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RejectedOffers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> RejectedOfferExists(int id)
        {
            // return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
            var rejectedoffer = await _unitOfWork.RejectedOffers.Get(q => q.Id == id);
            return rejectedoffer != null;
        }
    }
}
