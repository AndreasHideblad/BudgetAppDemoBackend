using JappCore.Models;
using JappCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Repositories
{
    public class RecurringExpenseRepository : Repository<RecurringExpense>, IRecurringExpenseRepository
    {
        public RecurringExpenseRepository(JappCoreDatabaseContext _jappCoreDatabaseContext) : base(_jappCoreDatabaseContext)
        {

        }
    }
}
