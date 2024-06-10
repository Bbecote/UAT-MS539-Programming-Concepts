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
    internal static class DBManager
    {

        private static HashSet<int> modifiedTransactionIDs = new HashSet<int>();

        //----- ACCOUNT DETAILS FROM DATABASE -----//
        internal static Account GetAccountFromDatabase(string accountName)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                string query = @"
                            SELECT * 
                            FROM Account
                            WHERE AccountName = @accountName";
                var account = connection.QueryFirstOrDefault<Account>(query, new { accountName });
                if (account == null)
                {
                    return account; //Needs evaluation
                }
                else
                {
                    GetTransactionDetailsFromDatabase(account, connection);
                    return account;
                }
            }
        }

        //----- TRANSACTION DETAILS ADDED TO A LIST ASSOCIATED WITH THE ACCOUNT OBJECT -----//
        private static void GetTransactionDetailsFromDatabase(Account account, SQLiteConnection connection)
        {
            string query = @"
                            SELECT *
                            FROM TransactionList 
                            WHERE AccountName = @AccountName";
            account.Transactions = connection.Query<Transaction>(query, new { AccountName = account.AccountName }).ToList();
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //----- UPDATING Modified Transactions -----//
        //TODO a method or means of deleting Transactions
        public static void UpdateModifiedTransactions(int amount)
        {
            if (modifiedTransactionIDs.Count == 0) return;
            string query = @"
                            UPDATE TransactionList
                            SET Amount = @amount
                            WHERE TransactionID IN @modfiedTransactionIDs";
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute(query, new { amount,  modifiedTransactionIDs = modifiedTransactionIDs });
            }
        }



    }
}
