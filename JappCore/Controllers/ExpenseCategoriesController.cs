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
    public class ExpenseCategoriesController : ControllerBase
    {
        private readonly IExpenseCategoryService _expenseCategoryService;

        public ExpenseCategoriesController(IExpenseCategoryService expenseCategoryService)
        {
            _expenseCategoryService = expenseCategoryService;
        }

        // GET: api/ExpenseCategories
        [HttpGet]
        public IQueryable<ExpenseCategory> GetAllExpenseCategories()
        {
            return _expenseCategoryService.GetAllExpenseCategories();
        }

        // GET: api/ExpenseCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseCategory>> GetExpenseCategoryById(int id)
        {
            return await _expenseCategoryService.GetExpenseCategoryById(id);
        }

        // PUT: api/ExpenseCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateExpenseCategory(int id, ExpenseCategory expenseCategory)
        {
            if (id == expenseCategory.Id)
            {
                await _expenseCategoryService.UpdateExpenseCategory(expenseCategory);
            }
            else
            {
                return BadRequest();
            }

            return Ok();
        }

        // POST: api/ExpenseCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExpenseCategory>> CreateExpenseCategory(ExpenseCategory expenseCategory)
        {
            return await _expenseCategoryService.CreateExpenseCategory(expenseCategory);
        }

        //DELETE: api/ExpenseCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExpenseCategory>> DeleteExpenseCategory(int id)
        {
            return await _expenseCategoryService.DeleteExpenseCategory(id);
        }
    }
}
