using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SQLite;
using System.Configuration;
using System.Security.Principal;
using System.Transactions;
using System.Data;
using System.Linq;

namespace BudgetManager
{
    internal class DBManager
    {
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
                    return new Account(); //TODO create an empty/default account
                }
                else
                {
                    GetBudgetTable(account, connection);
                    return account;
                }
            }
        }

        //----- GetTable ----//
        private static void GetBudgetTable(Account currentAccount, SQLiteConnection connection)
        {
            string query = @"
                            SELECT *
                            FROM BudgetTable 
                            WHERE AccountName = @AccountName";
            var budgetTable = connection.Query<DataTable>(query, new { AccountName = currentAccount.AccountName });
            
            //If a budget table doesn't exist, create one and update the database
            if (budgetTable == null)
            {
                DataTable newBudgetTable = MakeDataTable(currentAccount, connection);
                string createTableQuery = MakeDBTableStatement(newBudgetTable);
                connection.Execute(createTableQuery);
                foreach (DataRow row in newBudgetTable.Rows)
                {
                    string insertQuery = MakeInsertStatement(newBudgetTable);
                    var parameters = MakeInsertParameters(row);
                    connection.Execute(insertQuery, parameters);
                }
            }
            else
            {
                //Update the budgettable
                //If needed update the database
                //return a budgetTable
                //currentAccount.DataTable = budgetTable;
            }
        }

        private static string MakeDBTableStatement(DataTable table) 
        { 
            List<string> columnDefenitions = new List<string>();
            foreach (DataColumn column in table.Columns)
            {
                string columnName = column.ColumnName;
                string columnType = GetDBColumnType(column.DataType); 
                columnDefenitions.Add($"{columnName} {columnType}");
            }
            string tableName = table.TableName;
            return $"CREATE TABLE IF NOT EXISTS {tableName} ({string.Join(", ", columnDefenitions)}";
        }

        private static string MakeInsertStatement(DataTable table)
        {
            string tableName = table.TableName;
            string[] columnName = table.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray();
            string[] parameterPlaceHolders = table.Columns.Cast<DataColumn>().Select(c => "@" + c.ColumnName).ToArray();

            return $"INSERT INTO {tableName} ({string.Join(", ", columnName)}) VALUES ({string.Join(", ", parameterPlaceHolders)})";
        }

        private static DynamicParameters MakeInsertParameters(DataRow row)
        {
            var parameters = new DynamicParameters();
            foreach (DataColumn column in row.Table.Columns)
            {
                parameters.Add("@" + column.ColumnName, row[column]);
            }
            return parameters ;
        }

        private static string GetDBColumnType(Type datatype)
        {
            if (datatype == typeof(string))
            {
                return "TEXT";
            }
            else if (datatype == typeof(decimal))
            {
                return "REAL";
            }
            else throw new NotSupportedException($"Unsupported data type {datatype}");
        }


        //----- TRANSACTION DETAILS ADDED TO A LIST ASSOCIATED WITH THE ACCOUNT OBJECT -----//
        private static void GetTransactionDetailsFromDatabase(Account currentAccount, SQLiteConnection connection)
        {
            string query = @"
                            SELECT *
                            FROM TransactionList 
                            WHERE AccountName = @AccountName";
            var transactions = connection.Query<TransactionData>(query, new { AccountName = currentAccount.AccountName });

            foreach (TransactionData transaction in transactions)
            {
                var itemType = new TransactionData
                {
                    Category = transaction.Category,
                    Description = transaction.Description,
                    Type = transaction.Type,
                    Date = transaction.Date,
                    Amount = transaction.Amount,
                };
                currentAccount.TransactionsDataSource.Add(itemType);
            }
        }

        private static DataTable MakeDataTable(Account account, SQLiteConnection connection)
        {
            DataTable budgetTable = new DataTable($"{account.AccountName} BudgetTable");
            DataColumn summary = new DataColumn("Summary", typeof(string));
            List<DataColumn> budgetColumns = new List<DataColumn>();

            //Create Columns
            budgetTable.Columns.Add("Summary", typeof(string));
            budgetColumns.AddRange(ColumnData.GenerateColumnData(account));
            
            //Create Rows
            budgetTable.Rows.Add("Opening Cash", typeof(decimal));
            budgetTable.Rows.Add("Total Income", typeof(decimal));
            budgetTable.Rows.Add("Total Expenditures", typeof(decimal));
            budgetTable.Rows.Add("Net Cash Flow", typeof(decimal));
            budgetTable.Rows.Add("Current Balance", typeof(decimal));
            budgetTable.Rows.Add("Opening Cash", typeof(decimal));


            //Update Database & return 

            return budgetTable;
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }




    }
}
