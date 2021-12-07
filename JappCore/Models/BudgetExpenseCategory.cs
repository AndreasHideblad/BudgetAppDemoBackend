using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class BudgetExpenseCategory
    {
        public int BudgetId { get; set; }
        public int ExpenseCategoryId { get; set; }
        public int? BudgetId1 { get; set; }
        public int Sum { get; set; }

        public virtual Budget BudgetId1Navigation { get; set; }
        public virtual ExpenseCategory ExpenseCategory { get; set; }
    }
}
