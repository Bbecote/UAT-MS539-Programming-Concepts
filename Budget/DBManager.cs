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
    internal class DBManager
    {
        //----- ACCOUNT DETAILS FROM DATABASE -----//
        internal static Dictionary<string, List<Account>> GetAccountDetailsFromDatabase()
        {
            var accountRows = new Dictionary<string, List<Account>>();
            string query = @"SELECT AccountID, AccountName, AccountType, StartDate, OpeningBalance, ClosingDate, Image " + "FROM Account a";
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var result = connection.Query<Account>(query);
                foreach (var account in result)
                {
                    if (accountRows.ContainsKey(account.AccountName))
                    {
                        accountRows[account.AccountName].Add(account);
                    }
                    else
                    {
                        accountRows[account.AccountName] = new List<Account> { account };
                    }
                }
            }
            return accountRows;
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
