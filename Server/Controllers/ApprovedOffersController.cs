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
    public class ApprovedOffersController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ApprovedOffersController(IUnitOfWork unitOfWork)
        {
            // _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetApprovedOffers()
        {
            // return await _context.Categories.ToListAsync();
            var approvedoffers = await _unitOfWork.ApprovedOffers.GetAll(includes: q => q.Include(x => x.Offer).Include(x => x.Account));
            return Ok(approvedoffers);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetApprovedOffer(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var approvedoffer = await _unitOfWork.ApprovedOffers.Get(q => q.Id == id);

            if (approvedoffer == null)
            {
                return NotFound();
            }

            return Ok(approvedoffer);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApprovedOffer(int id, ApprovedOffer approvedoffer)
        {
            if (id != approvedoffer.Id)
            {
                return BadRequest();
            }

            //_context.Entry(category).State = EntityState.Modified;
            _unitOfWork.ApprovedOffers.Update(approvedoffer);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!CategoryExists(id))
                if (!await ApprovedOfferExists(id))
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
        public async Task<ActionResult<ApprovedOffer>> PostApprovedOffer(ApprovedOffer approvedoffer)
        {
            //_context.Categories.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ApprovedOffers.Insert(approvedoffer);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetOffers", new { id = approvedoffer.Id }, approvedoffer);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApprovedOffer(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var approvedoffer = await _unitOfWork.ApprovedOffers.Get(q => q.Id == id);
            if (approvedoffer == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ApprovedOffers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> ApprovedOfferExists(int id)
        {
            // return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
            var approvedoffer = await _unitOfWork.ApprovedOffers.Get(q => q.Id == id);
            return approvedoffer != null;
        }
    }
}
