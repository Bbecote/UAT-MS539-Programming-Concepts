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
    internal class Summary
    {
        public string Label { get; set; }
        public decimal Amount { get; set; }




        public static BindingList<Summary> SetSummary(string accountName)
        {
            Account account = Account.Accounts[accountName][0];
            BindingList<Summary> summaryItems = new BindingList<Summary>();
            DateTime accountStart = DateTime.Parse(account.StartDate);
            
            summaryItems.Add(new Summary
            {
                Label = "Opening Cash",
                Amount = account.OpeningBalance, //Grab from Account Object, Take next from Ending Balance
            });

            summaryItems.Add(new Summary
            {
                Label = "Total Income",
                Amount = 00, //Grab from Account Object, fill rest with getNext
            });

            summaryItems.Add(new Summary
            {
                Label = "Total Expenditures",
                Amount = 00 //Grab from Account Object, fill rest with getNext
            });

            summaryItems.Add(new Summary
            {
                Label = "Current Balance",
                Amount = 00 //Grab from Account Object,. fill rest with getNext
            });

            summaryItems.Add(new Summary
            {
                Label = "Net Cash Flow",
                Amount = 00 //Grab from Account Object, fill rest with getNext
            });

            summaryItems.Add(new Summary
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
