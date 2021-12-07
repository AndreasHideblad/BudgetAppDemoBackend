using JappCore.Models;
using JappCore.Repositories.Interfaces;
using JappCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services
{
    public class RecurringExpenseService : IRecurringExpenseService
    {
        private readonly IRecurringExpenseRepository _recurringExpenseRepository;

        public RecurringExpenseService(IRecurringExpenseRepository recurringExpenseRepository)
        {
            _recurringExpenseRepository = recurringExpenseRepository;
        }

        public async Task<RecurringExpense> CreateRecurringExpense(RecurringExpense recurringExpense)
        {
            return await _recurringExpenseRepository.Create(recurringExpense);
        }

        public async Task<RecurringExpense> DeleteRecurringExpense(int id)
        {
            return await _recurringExpenseRepository.Delete(id);
        }

        public IQueryable<RecurringExpense> GetAllRecurringExpenses()
        {
            return _recurringExpenseRepository.GetAll();
        }

        public async Task<RecurringExpense> GetRecurringExpenseById(int id)
        {
            return await _recurringExpenseRepository.GetById(id);
        }

        public async Task<RecurringExpense> UpdateRecurringExpense(RecurringExpense recurringExpense)
        {
            return await _recurringExpenseRepository.Update(recurringExpense);
        }
    }
}
