using JappCore.Models;
using JappCore.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Managers
{
    public class IncomeRepository : Repository<Income>, IIncomeRepository
    {
        public IncomeRepository(JappCoreDatabaseContext _jappCoreDatabaseContext) : base(_jappCoreDatabaseContext)
        {

        }

        //public Task<Income> GetIncomeByID(int id)
        //{
        //    return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        //}

        //public async Task<Income> Delete(int id)
        //{
        //    var deleteIncome = await _jappCoreDatabaseContext.Incomes.FindAsync(id);

        //    _jappCoreDatabaseContext.Incomes.Remove(deleteIncome);

        //    await _jappCoreDatabaseContext.SaveChangesAsync();

        //    return deleteIncome;
        //}

        //public async Task<Income> UpdateIncome(int id)
        //{
        //    var updateIncome = await _jappCoreDatabaseContext.Incomes.FindAsync(id);

        //    _jappCoreDatabaseContext.Incomes.Update(updateIncome);

        //    await _jappCoreDatabaseContext.SaveChangesAsync();

        //    return updateIncome;
        //}

        //public async Task<Income> CreateIncome(Income income)
        //{
        //    _jappCoreDatabaseContext.Incomes.Add(income);

        //    await _jappCoreDatabaseContext.SaveChangesAsync();

        //    return income;
        //}

        //public void CreateIncome(Income income)
        //{
        //    using (var db = new JappCoreDatabaseContext())
        //    {
        //        db.Incomes.Add(income);
        //        db.SaveChanges();
        //    }
        //}
        //public List<Income> GetAllIncome()
        //{
        //    using (var db = new JappCoreDatabaseContext())
        //    {
        //        var incomes = db.Incomes.ToList();
        //        return incomes;
        //    }
        //}

        //public void DeleteIncome(int ID)
        //{
        //    using (var db = new JappCoreDatabaseContext())
        //    {
        //        var income = db.Incomes.Where(s => s.Id == ID).FirstOrDefault();
        //        //db.Incomes.Remove(income);

        //        db.Entry(income).State = EntityState.Deleted;
        //        db.SaveChanges();
        //    }

        //}
        //public Income GetIncomeByID(int id)
        //{
        //    using (var db = new JappCoreDatabaseContext())
        //    {
        //        var incomes = db.Incomes.Find(id);
        //        return incomes;
        //    }
        //}

        //public void CreateIncome()
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteIncome()
        //{
        //    throw new NotImplementedException();
        //}

        //public Income GetIncomeByID()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
