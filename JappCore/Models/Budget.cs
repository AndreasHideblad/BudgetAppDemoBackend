using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class Budget
    {
        public Budget()
        {
            BudgetDeposits = new HashSet<BudgetDeposit>();
            BudgetExpenseCategories = new HashSet<BudgetExpenseCategory>();
            ExpenseCategories = new HashSet<ExpenseCategory>();
        }

        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int? UserAccountsId { get; set; }

        public virtual UserAccount UserAccounts { get; set; }
        public virtual ICollection<BudgetDeposit> BudgetDeposits { get; set; }
        public virtual ICollection<BudgetExpenseCategory> BudgetExpenseCategories { get; set; }
        public virtual ICollection<ExpenseCategory> ExpenseCategories { get; set; }
    }
}
