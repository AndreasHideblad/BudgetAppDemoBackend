using JappCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services.Interfaces
{
    public interface IExpenseCategoryService
    {
        IQueryable<ExpenseCategory> GetAllExpenseCategories();
        Task<ExpenseCategory> GetExpenseCategoryById(int id);
        Task<ExpenseCategory> CreateExpenseCategory(ExpenseCategory expenseCategory);
        Task<ExpenseCategory> UpdateExpenseCategory(ExpenseCategory expenseCategory);
        Task<ExpenseCategory> DeleteExpenseCategory(int id);
    }
}
