using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Transaction 
    {   
        public int TransactionID { get; set; }   
        public string AccountName { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public string TransactionType { get; set; }
        public bool isRecurring { get; set; }
        public string RecurringFrequency { get; set; }
        public DateTime ReccuringEndDate { get; set; }
        public string URL { get; set; }
        public bool IsVariable { get; set; }
        public bool IsAutomaticWithdrawal { get; set; }
        public bool IsPaid { get; set; }
        public bool IsDirty { get; set; }
        public string Label { get; set; }

        public static List<Transaction> GetTransactions(string transactionType, Account currentAccount)
        {
            Account CurrentAccount = currentAccount;
            List<Transaction> valuesList = new List<Transaction>();
            foreach (Transaction transaction in currentAccount.Transactions)
            {
                if (transaction.TransactionType == transactionType)
                {
                   valuesList.Add(transaction);
                }
            }
            return valuesList;
        }
    }
}
