using JappCore.Models;
using JappCore.Repositories;
using JappCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IIncomeRepository _incomeRepository;

        public IncomeService(IIncomeRepository incomeRepository)
        {
            _incomeRepository = incomeRepository;
        }

        public async Task<Income> CreateIncome(Income income)
        {
            return await _incomeRepository.Create(income);
        }

        public IQueryable<Income> GetAllIncomes()
        {
            return _incomeRepository.GetAll();
        }

        public async Task<Income> GetIncomeById(int id)
        {
            return await _incomeRepository.GetById(id);
        }

        public async Task<Income> UpdateIncome(Income income)
        {
            return await _incomeRepository.Update(income);
        }

        public async Task<Income> DeleteIncome(int id)
        {
            return await _incomeRepository.Delete(id); 
        }

        //private IIncomeRepository _incomeRepository;

        //public IncomeService(IIncomeRepository incomeRepository)
        //{
        //    _incomeRepository = incomeRepository;
        //}

        //public void CreateIncome()
        //{
        //    _incomeRepository.CreateIncome();
        //}

        //public void DeleteIncome()
        //{
        //    _incomeRepository.DeleteIncome();
        //}

        //public async Task<Income> GetAllIncome()
        //{
        //   //return await _incomeRepository.GetAllIncome();
        //}

        //public Income GetIncomeByID()
        //{
        //    return _incomeRepository.GetIncomeByID();
        //}

    }
}
