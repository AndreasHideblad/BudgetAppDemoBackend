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
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService _incomeService;

        public IncomeController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }

        // GET: api/Incomes
        [HttpGet]
        public IQueryable<Income> GetAllIncomes()
        {
            return _incomeService.GetAllIncomes();
        }

        // GET: api/Incomes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Income>> GetIncomeById(int id)
        {
            var income = await _incomeService.GetIncomeById(id);

            if (income == null)
            {
                return NotFound();
            }

            return income;
        }

        // PUT: api/Incomes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateIncome(int id, Income income)
        {
            if (id == income.Id)
            {
                await _incomeService.UpdateIncome(income);
            }
            else
            {
                return BadRequest();
            }

            return Ok();

            //try
            //{
            //    await _incomeService.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!IncomeExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return NoContent();
        }

        // POST: api/Incomes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Income>> CreateIncome(Income income)
        {
            return await _incomeService.CreateIncome(income);

            //return CreatedAtAction(nameof(Income), new { id = income.Id }, income);
        }

        // DELETE: api/Incomes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Income>> DeleteIncome(int id)
        {
            return await _incomeService.DeleteIncome(id);

            //var income = await _context.Incomes.FindAsync(id);
            //if (income == null)
            //{
            //    return NotFound();
            //}

            //_context.Incomes.Remove(income);
            //await _context.SaveChangesAsync();

            //return NoContent();
        }

        //private bool IncomeExists(int id)
        //{
        //    return _context.Incomes.Any(e => e.Id == id);
        //}
    }
}
