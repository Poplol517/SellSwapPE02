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
    public class ConditionTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConditionTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ConditionTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConditionType>>> GetConditionTypes()
        {
          if (_context.ConditionTypes == null)
          {
              return NotFound();
          }
            return await _context.ConditionTypes.ToListAsync();
        }

        // GET: api/ConditionTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConditionType>> GetConditionType(int id)
        {
          if (_context.ConditionTypes == null)
          {
              return NotFound();
          }
            var conditionType = await _context.ConditionTypes.FindAsync(id);

            if (conditionType == null)
            {
                return NotFound();
            }

            return conditionType;
        }

        // PUT: api/ConditionTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConditionType(int id, ConditionType conditionType)
        {
            if (id != conditionType.Id)
            {
                return BadRequest();
            }

            _context.Entry(conditionType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConditionTypeExists(id))
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

        // POST: api/ConditionTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConditionType>> PostConditionType(ConditionType conditionType)
        {
          if (_context.ConditionTypes == null)
          {
              return Problem("Entity set 'ApplicationDbContext.ConditionTypes'  is null.");
          }
            _context.ConditionTypes.Add(conditionType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConditionType", new { id = conditionType.Id }, conditionType);
        }

        // DELETE: api/ConditionTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConditionType(int id)
        {
            if (_context.ConditionTypes == null)
            {
                return NotFound();
            }
            var conditionType = await _context.ConditionTypes.FindAsync(id);
            if (conditionType == null)
            {
                return NotFound();
            }

            _context.ConditionTypes.Remove(conditionType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConditionTypeExists(int id)
        {
            return (_context.ConditionTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
