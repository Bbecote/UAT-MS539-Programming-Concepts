using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Transaction
    {
        public int TransactionID { get; set; }   
        public int AccountID { get; set; }
        public int CategoryID { get; set; }
        public double Amount { get; set; }
        public string TransactionDate { get; set; }
        public string Description { get; set; }
        public string TransactionType { get; set; }
        public int isRecurring { get; set; }
        public string RecurringFrequency { get; set; }
        public string ReccuringEndDate { get; set; }
        public string URL { get; set; }
        public int Variation { get; set; }
        public int AutomaticWithdrawal { get; set; }
        public int IsPaid { get; set; }

    }
}
