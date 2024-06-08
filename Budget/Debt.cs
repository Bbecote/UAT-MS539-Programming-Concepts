using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Debt
    {
        public int DebtID { get; set; }
        public int AccountID { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public double InterestRate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

    }
}
