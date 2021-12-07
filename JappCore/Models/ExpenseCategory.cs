using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class ExpenseCategory
    {
        public ExpenseCategory()
        {
            BudgetExpenseCategories = new HashSet<BudgetExpenseCategory>();
            Expenses = new HashSet<Expense>();
            RecurringExpenses = new HashSet<RecurringExpense>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? BudgetId { get; set; }

        public virtual Budget Budget { get; set; }
        public virtual ICollection<BudgetExpenseCategory> BudgetExpenseCategories { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<RecurringExpense> RecurringExpenses { get; set; }
    }
}
