using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManager
{
    public class TransactionData
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }
        public Dictionary<string, decimal> Transactions { get; set; } = new Dictionary<string, decimal>();
    }
}
