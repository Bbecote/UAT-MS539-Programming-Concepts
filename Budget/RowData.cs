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

namespace Budget
{
    internal class RowData
    {
        public string Label { get; set; }
        public decimal Amount { get; set; }
        public Transaction Transaction { get; set; }

        public static List<RowData> GetRows(Account currentAccount)
        {
            Account CurrentAccount = currentAccount;
            List<RowData> summaryItems = new List<RowData>();
            
            summaryItems.Add(new RowData
            {
                Label = "Opening Cash",
                Amount = CurrentAccount.OpeningBalance, //Grab from Account Object, Take next from Ending Balance
            });

            summaryItems.Add(new RowData
            {
                Label = "Total Income",
                Amount = 00, //Grab from Account Object, fill rest with getNext
            });

            summaryItems.Add(new RowData
            {
                Label = "Total Expenditures",
                Amount = 00 //Grab from Account Object, fill rest with getNext
            });

            summaryItems.Add(new RowData
            {
                Label = "Current Balance",
                Amount = 00 //Grab from Account Object,. fill rest with getNext
            });

            summaryItems.Add(new RowData
            {
                Label = "Net Cash Flow",
                Amount = 00 //Grab from Account Object, fill rest with getNext
            });

            summaryItems.Add(new RowData
            {
                Label = "Ending Balance",
                Amount = 00 //Grab from Account Object, fill rest with getNext
            });

            return summaryItems;
        }

        private decimal getNextOpeningCash()
        {
            return 0;
        }

        private decimal getNextTotalIncome()
        {
            return 0;
        }

        private decimal getNextTotalExpenditures()
        {
            return 0;
        }
        private decimal getNextCurrentBalance()
        {
            return 0;
        }

        private decimal getNextNetCashFlow()
        {
            return 0;
        }

        private decimal getNextEndingBalance()
        {
            return 0;
        }
    }
}
