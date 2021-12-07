using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class Expense
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public int? UserAccountId { get; set; }
        public int? PayeeId { get; set; }
        public int? ExpenseCategoriesId { get; set; }
        public int? RecurringId { get; set; }

        public virtual ExpenseCategory ExpenseCategories { get; set; }
        public virtual Payee Payee { get; set; }
        public virtual Recurring Recurring { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
