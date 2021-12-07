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
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseService _expenseService;

        public ExpensesController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        // GET: api/Expenses
        [HttpGet]
        public IQueryable<Expense> GetAllExpenses()
        {
            return _expenseService.GetallExpenses();
        }

        // GET: api/Expenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpenseById(int id)
        {
            return await _expenseService.GetExpenseById(id);

            //var expense = await _expenseService.GetExpenseById(id);

            //if (expense == null)
            //{
            //    return NotFound();
            //}

            //return expense;
        }

        // PUT: api/Expenses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateExpense(int id, Expense expense)
        {
            if (id == expense.Id)
            {
                await _expenseService.UpdateExpense(expense);
            }
            else
            {
                return BadRequest();
            }

            return Ok();
        }

        // POST: api/Expenses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Expense>> CreateExpense(Expense expense)
        {
            return await _expenseService.CreateExpense(expense);
        }

        // DELETE: api/Expenses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Expense>> DeleteExpense(int id)
        {
            return await _expenseService.DeleteExpense(id);
        }
    }
}
