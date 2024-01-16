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
    public class ConditionTypesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ConditionTypesController(IUnitOfWork unitOfWork)
        {
            // _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetConditionTypes()
        {
            // return await _context.Categories.ToListAsync();
            var conditiontypes = await _unitOfWork.ConditionTypes.GetAll();
            return Ok(conditiontypes);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetConditionTypes(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var conditiontype = await _unitOfWork.ConditionTypes.Get(q => q.Id == id);

            if (conditiontype == null)
            {
                return NotFound();
            }

            return Ok(conditiontype);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConditionType(int id, ConditionType conditiontype)
        {
            if (id != conditiontype.Id)
            {
                return BadRequest();
            }

            //_context.Entry(category).State = EntityState.Modified;
            _unitOfWork.ConditionTypes.Update(conditiontype);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!CategoryExists(id))
                if (!await ConditionTypeExists(id))
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
        public async Task<ActionResult<ConditionType>> PostConditionType(ConditionType conditiontype)
        {
            //_context.Categories.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ConditionTypes.Insert(conditiontype);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetConditiontype", new { id = conditiontype.Id }, conditiontype);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConditiontype(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var conditiontype= await _unitOfWork.ConditionTypes.Get(q => q.Id == id);
            if (conditiontype == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.ConditionTypes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> ConditionTypeExists(int id)
        {
            // return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
            var conditiontype = await _unitOfWork.ConditionTypes.Get(q => q.Id == id);
            return conditiontype != null;
        }
    }
}
