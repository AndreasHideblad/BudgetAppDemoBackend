using JappCore.Models;
using JappCore.Repositories.Interfaces;
using JappCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services
{
    public class RecurringService : IRecurringService
    {
        private readonly IRecurringRepository _recurringRepository;

        public RecurringService(IRecurringRepository recurringRepository)
        {
            _recurringRepository = recurringRepository;
        }
        public async Task<Recurring> CreateRecurring(Recurring recurring)
        {
            return await _recurringRepository.Create(recurring);
        }

        public async Task<Recurring> DeleteRecurring(int id)
        {
            return await _recurringRepository.Delete(id);
        }

        public IQueryable<Recurring> GetAllRecurring()
        {
            return _recurringRepository.GetAll();
        }

        public async Task<Recurring> GetRecurringById(int id)
        {
            return await _recurringRepository.GetById(id);
        }

        public async Task<Recurring> UpdateRecurring(Recurring recurring)
        {
            return await _recurringRepository.Update(recurring);
        }
    }
}
