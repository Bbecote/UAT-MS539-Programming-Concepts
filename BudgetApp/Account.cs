using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.ComponentModel;

namespace BudgetApp
{
    public class Account
    {
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public decimal OpeningBalance { get; set; }
        public byte[] Image { get; set; }
        public BindingList<TransactionData> TransactionsDataSource { get; set; } = new BindingList<TransactionData>();

        public Account()
        {

        }

        public Account(string accountName, string accountType, string startDate, string closingDate, decimal openingBalance, byte[] image)
        {
            AccountName = accountName;
            AccountType = accountType;
            StartDate = DateTime.Parse(startDate);
            ClosingDate = DateTime.Parse(closingDate);
            OpeningBalance = openingBalance;
            Image = image;
        }
    }
}