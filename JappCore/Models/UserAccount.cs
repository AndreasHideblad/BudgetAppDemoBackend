using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            Budgets = new HashSet<Budget>();
            Expenses = new HashSet<Expense>();
            Incomes = new HashSet<Income>();
            SavingsTargets = new HashSet<SavingsTarget>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<SavingsTarget> SavingsTargets { get; set; }
    }
}
