using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class Recurring
    {
        public Recurring()
        {
            Expenses = new HashSet<Expense>();
            RecurringExpenses = new HashSet<RecurringExpense>();
        }

        public int Id { get; set; }
        public string RecurringOptions { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<RecurringExpense> RecurringExpenses { get; set; }
    }
}
