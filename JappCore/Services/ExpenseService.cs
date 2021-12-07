using JappCore.Models;
using JappCore.Repositories.Interfaces;
using JappCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task<Expense> CreateExpense(Expense expense)
        {
            return await _expenseRepository.Create(expense);
        }

        public IQueryable<Expense> GetallExpenses()
        {
            return _expenseRepository.GetAll();
        }

        public async Task<Expense> GetExpenseById(int id)
        {
            return await _expenseRepository.GetById(id);
        }

        public async Task<Expense> UpdateExpense(Expense expense)
        {
            return await _expenseRepository.Update(expense);
        }

        public async Task<Expense> DeleteExpense(int id)
        {
            return await _expenseRepository.Delete(id); 
        }
    }
}
