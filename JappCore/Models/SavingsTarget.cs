using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class SavingsTarget
    {
        public SavingsTarget()
        {
            Deposits = new HashSet<Deposit>();
        }

        public int Id { get; set; }
        public double Amount { get; set; }
        public string Name { get; set; }
        public DateTime EndDate { get; set; }
        public int? UserAccountId { get; set; }

        public virtual UserAccount UserAccount { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
    }
}
