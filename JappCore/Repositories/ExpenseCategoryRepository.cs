using JappCore.Models;
using JappCore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Repositories
{
    public class ExpenseCategoryRepository : Repository<ExpenseCategory>, IExpenseCategoryRepository
    {
        public ExpenseCategoryRepository(JappCoreDatabaseContext _jappCoreDatabaseContext) : base(_jappCoreDatabaseContext)
        {

        }

        //public Task<ExpenseCategory> GetExpenseCategoryById(ExpenseCategory expenseCategory)
        //{
        //    return GetAll().FirstOrDefaultAsync(x => x.Id == expenseCategory.Id);
        //}

        //public async Task<ExpenseCategory> DeleteExpenseCategory(ExpenseCategory expenseCategory)
        //{
        //    var deleteExpenseCategory = await _jappCoreDatabaseContext.ExpenseCategories.FindAsync(expenseCategory);
            
        //    _jappCoreDatabaseContext.ExpenseCategories.Remove(deleteExpenseCategory);

        //    await _jappCoreDatabaseContext.SaveChangesAsync();

        //    return deleteExpenseCategory;
        //}

        //public async Task<ExpenseCategory> UpdateExpenseCategory(ExpenseCategory expenseCategory)
        //{
        //    var updateExpenseCategory = await _jappCoreDatabaseContext.ExpenseCategories.FindAsync(expenseCategory);

        //    _jappCoreDatabaseContext.ExpenseCategories.Update(updateExpenseCategory);

        //    await _jappCoreDatabaseContext.SaveChangesAsync();

        //    return updateExpenseCategory;
        //}

        //public async Task<ExpenseCategory> CreateExpenseCategory(ExpenseCategory expenseCategory)
        //{
        //    _jappCoreDatabaseContext.ExpenseCategories.Add(expenseCategory);

        //    await _jappCoreDatabaseContext.SaveChangesAsync();

        //    return expenseCategory;
        //}
    }
}
