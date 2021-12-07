using JappCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Services.Interfaces
{
    public interface IRecurringService
    {
        IQueryable<Recurring> GetAllRecurring();
        Task<Recurring> GetRecurringById(int id);
        Task<Recurring> CreateRecurring(Recurring recurring);
        Task<Recurring> UpdateRecurring(Recurring recurring);
        Task<Recurring> DeleteRecurring(int id);
    }
}
