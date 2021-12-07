using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class BudgetDeposit
    {
        public int BudgetId { get; set; }
        public int DepositsId { get; set; }

        public virtual Budget Budget { get; set; }
        public virtual Deposit Deposits { get; set; }
    }
}
