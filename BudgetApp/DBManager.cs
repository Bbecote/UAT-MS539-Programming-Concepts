using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Dapper;
using System.Data.SQLite;

namespace BudgetApp
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
        private static void GetTransactionDetailsFromDatabase(Account currentAccount, SQLiteConnection connection)
        {
            string query = @"
                            SELECT *
                            FROM TransactionList 
                            WHERE AccountName = @AccountName";
            var transactions = connection.Query<Transaction>(query, new { AccountName = currentAccount.AccountName });

            foreach (Transaction transaction in transactions)
            {
                var itemType = new TransactionData
                {
                    Description = transaction.Description,
                    Type = transaction.TransactionType,
                    Category = transaction.CategoryName,
                    Amount = transaction.Amount,
                };
                //itemType.Transactions.Add(transaction.TransactionDate.ToString(), transaction.Amount);
                currentAccount.TransactionsDataSource.Add(itemType);
            }
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
                connection.Execute(query, new { amount, modifiedTransactionIDs = modifiedTransactionIDs });
            }
        }
    }
}
