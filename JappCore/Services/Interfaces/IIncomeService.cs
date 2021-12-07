using JappCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services.Interfaces
{
    public interface IIncomeService
    {
        IQueryable<Income> GetAllIncomes();
        Task<Income> GetIncomeById(int id);
        Task<Income> CreateIncome(Income income);
        Task<Income> UpdateIncome(Income income);
        Task<Income> DeleteIncome(int id);
    }
}



//void CreateIncome();
//Income GetIncomeByID();
//List<Income> GetAllIncome();
//void DeleteIncome();