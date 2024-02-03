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
    public class ConversationsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public ConversationsController(IUnitOfWork unitOfWork)
        {
            // _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetConversations()
        {
            // return await _context.Categories.ToListAsync();
            var conversations = await _unitOfWork.Conversations.GetAll(includes: q => q.Include(x => x.Listing));
            return Ok(conversations);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetConversation(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var conversation = await _unitOfWork.Conversations.Get(q => q.Id == id);

            if (conversation == null)
            {
                return NotFound();
            }

            return Ok(conversation);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConversation(int id, Conversation conversation)
        {
            if (id != conversation.Id)
            {
                return BadRequest();
            }

            //_context.Entry(category).State = EntityState.Modified;
            _unitOfWork.Conversations.Update(conversation);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!CategoryExists(id))
                if (!await ConversationExists(id))
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
        public async Task<ActionResult<Conversation>> PostConversation(Conversation conversation)
        {
            //_context.Categories.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Conversations.Insert(conversation);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetConversations", new { id = conversation.Id }, conversation);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConversation(int id)
        {
            //var category = await _context.Categories.FindAsync(id);
            var conversation = await _unitOfWork.Conversations.Get(q => q.Id == id);
            if (conversation == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Conversations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> ConversationExists(int id)
        {
            // return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
            var conversation = await _unitOfWork.Conversations.Get(q => q.Id == id);
            return conversation != null;
        }
    }
}
