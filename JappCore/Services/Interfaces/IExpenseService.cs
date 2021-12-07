using JappCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services.Interfaces
{
    public interface IExpenseService
    {
        IQueryable<Expense> GetallExpenses();
        Task<Expense> GetExpenseById(int id);
        Task<Expense> CreateExpense(Expense expense);
        Task<Expense> UpdateExpense(Expense expense);
        Task<Expense> DeleteExpense(int id);
    }
}
