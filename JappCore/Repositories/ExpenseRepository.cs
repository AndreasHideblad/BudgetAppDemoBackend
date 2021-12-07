using JappCore.Models;
using JappCore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Repositories
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(JappCoreDatabaseContext _jappCoreDatabaseContext) : base(_jappCoreDatabaseContext)
        {

        }

        //public Task<Expense> GetExpenseByID(int id)
        //{
        //    return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        //}

        //public async Task<Expense> DeleteExpense(int id)
        //{
        //    var deleteExpense = await _jappCoreDatabaseContext.Expenses.FindAsync(id);

        //    _jappCoreDatabaseContext.Expenses.Remove(deleteExpense);

        //    await _jappCoreDatabaseContext.SaveChangesAsync();

        //    return deleteExpense;
        //}

        //public async Task<Expense> UpdateExpense(int id)
        //{
        //    var updateExpense = await _jappCoreDatabaseContext.Expenses.FindAsync(id);

        //    _jappCoreDatabaseContext.Expenses.Update(updateExpense);

        //    await _jappCoreDatabaseContext.SaveChangesAsync();

        //    return updateExpense;
        //}

        //public async Task<Expense> CreateExpense(Expense expense)
        //{
        //    _jappCoreDatabaseContext.Expenses.Add(expense);

        //    await _jappCoreDatabaseContext.SaveChangesAsync();

        //    return expense;
        //}
    }
}
