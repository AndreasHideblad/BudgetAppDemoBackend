using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JappCore.Models;

namespace JappCore.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsTargetsController : ControllerBase
    {
        private readonly JappCoreDatabaseContext _context;

        public SavingsTargetsController(JappCoreDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/SavingsTargets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SavingsTarget>>> GetSavingsTargets()
        {
            return await _context.SavingsTargets.ToListAsync();
        }

        // GET: api/SavingsTargets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SavingsTarget>> GetSavingsTarget(int id)
        {
            var savingsTarget = await _context.SavingsTargets.FindAsync(id);

            if (savingsTarget == null)
            {
                return NotFound();
            }

            return savingsTarget;
        }

        // PUT: api/SavingsTargets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSavingsTarget(int id, SavingsTarget savingsTarget)
        {
            if (id != savingsTarget.Id)
            {
                return BadRequest();
            }

            _context.Entry(savingsTarget).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SavingsTargetExists(id))
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

        // POST: api/SavingsTargets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SavingsTarget>> PostSavingsTarget(SavingsTarget savingsTarget)
        {
            _context.SavingsTargets.Add(savingsTarget);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSavingsTarget", new { id = savingsTarget.Id }, savingsTarget);
        }

        // DELETE: api/SavingsTargets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavingsTarget(int id)
        {
            var savingsTarget = await _context.SavingsTargets.FindAsync(id);
            if (savingsTarget == null)
            {
                return NotFound();
            }

            _context.SavingsTargets.Remove(savingsTarget);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SavingsTargetExists(int id)
        {
            return _context.SavingsTargets.Any(e => e.Id == id);
        }
    }
}
