using JappCore.Models;
using JappCore.Repositories.Interfaces;
using JappCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services
{
    public class ExpenseCategoryService : IExpenseCategoryService
    {
        private readonly IExpenseCategoryRepository _expenseCategoryRepository;

        public ExpenseCategoryService(IExpenseCategoryRepository expenseCategoryRepository)
        {
            _expenseCategoryRepository = expenseCategoryRepository;
        }

        public async Task<ExpenseCategory> CreateExpenseCategory(ExpenseCategory expenseCategory)
        {
            return await _expenseCategoryRepository.Create(expenseCategory);
        }

        public IQueryable<ExpenseCategory> GetAllExpenseCategories()
        {
            return _expenseCategoryRepository.GetAll();
        }

        public async Task<ExpenseCategory> GetExpenseCategoryById(int id)
        {
            return await _expenseCategoryRepository.GetById(id);
        }

        public async Task<ExpenseCategory> UpdateExpenseCategory(ExpenseCategory expenseCategory)
        {
            return await _expenseCategoryRepository.Update(expenseCategory);
        }

        public async Task<ExpenseCategory> DeleteExpenseCategory(int id)
        {
            return await _expenseCategoryRepository.Delete(id);
        }
    }
}
