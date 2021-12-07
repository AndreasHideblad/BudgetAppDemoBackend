using System;
using System.Collections.Generic;

#nullable disable

namespace JappCore.Models
{
    public partial class Income
    {
        public int Id { get; set; }
        //public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public int? UserAccountId { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}
