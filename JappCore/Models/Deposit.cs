using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class Deposit
    {
        public Deposit()
        {
            BudgetDeposits = new HashSet<BudgetDeposit>();
        }

        public int Id { get; set; }
        public double Amount { get; set; }
        public int? SavingsTargetsId { get; set; }

        public virtual SavingsTarget SavingsTargets { get; set; }
        public virtual ICollection<BudgetDeposit> BudgetDeposits { get; set; }
    }
}
