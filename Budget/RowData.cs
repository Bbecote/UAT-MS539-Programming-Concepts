using System.Data;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Security.Policy;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Transactions;

namespace Budget
{
    internal class RowData
    {
        public string Description { get; set; }
        public static BindingList<List<Transaction>> TransactionsList { get; set; } = new BindingList<List<Transaction>>();

        public static void AddRows(Account currentAccount)
        {
            List<Transaction> summaryList = new();
            //SetSummaryRows(currentAccount);

            //Space Between Summary and Income
            summaryList.Add(new Transaction { Description = null });  //Need to update the table to all null Descriptions
            TransactionsList.Add(summaryList);

            //Income rows
            List<Transaction> incomeTransactions = Transaction.GetTransactions("Income", currentAccount);

            var groupedTransactions = incomeTransactions.GroupBy(t => t.Description).Select(group => group.ToList()).ToList();
            foreach (var list in groupedTransactions)
            {
                TransactionsList.Add(list);
            }

            //Space Between Summary and Income
            summaryList.Clear();
            summaryList.Add(new Transaction { Description = null });  //Need to update the table to all null Descriptions
            TransactionsList.Add(summaryList);

            //Expense rows
            List<Transaction> expenseTransactions = Transaction.GetTransactions("Expense", currentAccount);

            groupedTransactions = expenseTransactions.GroupBy(t => t.Description).Select(group => group.ToList()).ToList();
            foreach (var list in groupedTransactions)
            {
                TransactionsList.Add(list);
            }

            BindingList<List<Transaction>> test = TransactionsList;
    }

        private static void SetSummaryRows(Account currentAccount)
        {
            Account CurrentAccount = currentAccount;
            List<Transaction> summaryList = new ();

            summaryList.Add(new Transaction
            {
                Description = "Opening Cash",
            });
            TransactionsList.Add(summaryList);
            summaryList.Clear();

            summaryList.Add(new Transaction
            {
                Description = "Total Income",
            });
            TransactionsList.Add(summaryList);
            summaryList.Clear();

            summaryList.Add(new Transaction
            {
                Description = "Total Expenditures",
            });
            TransactionsList.Add(summaryList);
            summaryList.Clear();

            summaryList.Add(new Transaction
            {
                Description = "Current Balance",
                Amount = 00 //Grab from Account Object,. fill rest with getNext
            });
            TransactionsList.Add(summaryList);
            summaryList.Clear();

            summaryList.Add(new Transaction
            {
                Description = "Net Cash Flow",
                Amount = 00 //Grab from Account Object, fill rest with getNext
            });
            TransactionsList.Add(summaryList);
            summaryList.Clear();

            summaryList.Add(new Transaction
            {
                Description = "Ending Balance",
                Amount = 00 //Grab from Account Object, fill rest with getNext
            });
            TransactionsList.Add(summaryList);
            summaryList.Clear();
        }
    }
}
