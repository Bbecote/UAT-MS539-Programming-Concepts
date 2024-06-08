using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class DebtPayment
    {
        public int PaymentID { get; set; }
        public int DebtID { get; set; }
        public string PaymentDate { get; set; }
        public double Amount { get; set; }
    }
}
