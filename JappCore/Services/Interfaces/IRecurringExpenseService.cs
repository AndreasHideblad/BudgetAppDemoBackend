using JappCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services.Interfaces
{
    public interface IRecurringExpenseService
    {
        IQueryable<RecurringExpense> GetAllRecurringExpenses();
        Task<RecurringExpense> GetRecurringExpenseById(int id);
        Task<RecurringExpense> CreateRecurringExpense(RecurringExpense recurringExpense);
        Task<RecurringExpense> UpdateRecurringExpense(RecurringExpense recurringExpense);
        Task<RecurringExpense> DeleteRecurringExpense(int id);

    }
}
