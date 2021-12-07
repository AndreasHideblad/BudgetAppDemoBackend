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
    public class RecurringExpensesController : ControllerBase
    {
        private readonly IRecurringExpenseService _recurringExpenseService;

        public RecurringExpensesController(IRecurringExpenseService recurringExpenseService)
        {
            _recurringExpenseService = recurringExpenseService;
        }

        // GET: api/RecurringExpenses
        [HttpGet]
        public IQueryable<RecurringExpense> GetAllRecurringExpenses()
        {
            return _recurringExpenseService.GetAllRecurringExpenses();
        }

        // GET: api/RecurringExpenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecurringExpense>> GetRecurringExpenseById(int id)
        {
            return await _recurringExpenseService.GetRecurringExpenseById(id);
        }

        // PUT: api/RecurringExpenses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<RecurringExpense>> UpdateRecurringExpense(int id, RecurringExpense recurringExpense)
        {
            if (id == recurringExpense.Id)
            {
                await _recurringExpenseService.UpdateRecurringExpense(recurringExpense);
            }
            else
            {
                return BadRequest();
            }

            return Ok();
        }

        // POST: api/RecurringExpenses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RecurringExpense>> CreateRecurringExpense(RecurringExpense recurringExpense)
        {
            return await _recurringExpenseService.CreateRecurringExpense(recurringExpense);
        }

        // DELETE: api/RecurringExpenses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RecurringExpense>> DeleteRecurringExpense(int id)
        {
            return await _recurringExpenseService.DeleteRecurringExpense(id);
        }
    }
}
