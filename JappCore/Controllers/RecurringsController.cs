using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JappCore.Models;
using JappCore.Services.Interfaces;

namespace JappCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecurringsController : ControllerBase
    {
        private readonly IRecurringService _recurringService;

        public RecurringsController(IRecurringService recurringService)
        {
            _recurringService = recurringService;
        }

        // GET: api/Recurrings
        [HttpGet]
        public IQueryable<Recurring> GetAllRecurrings()
        {
            return _recurringService.GetAllRecurring();
        }

        // GET: api/Recurrings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recurring>> GetRecurringById(int id)
        {
            return await _recurringService.GetRecurringById(id);

            //var recurring = await _context.Recurrings.FindAsync(id);

            //if (recurring == null)
            //{
            //    return NotFound();
            //}

            //return recurring;
        }

        // PUT: api/Recurrings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateRecurring(int id, Recurring recurring)
        {
            if (id == recurring.Id)
            {
                await _recurringService.UpdateRecurring(recurring);
            }
            else
            {
                return BadRequest();
            }

            return Ok();
        }

        // POST: api/Recurrings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Recurring>> CreateRecurring(Recurring recurring)
        {
            return await _recurringService.CreateRecurring(recurring);
        }

        // DELETE: api/Recurrings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Recurring>> DeleteRecurring(int id)
        {
            return await _recurringService.DeleteRecurring(id);
        }
    }
}
