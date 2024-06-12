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
using System.Collections;
using System.ComponentModel;
using System.Transactions;
using System.Data.Common;


namespace Budget
{
    public partial class Form1 : Form
    {

        Account CurrentAccount;

        public Form1()
        {
            this.CurrentAccount = DBManager.GetAccountFromDatabase("NavyFed"); //TODO Update this with a user selected option
            InitializeComponent();
            SetupDataGridViews();
        }
        private void SetupDataGridViews()
        {
            //dataGridView_Main.BackgroundColor = Color.Black;
            dataGridView_Main.Location = new Point(0, 0);
            dataGridView_Main.Dock = DockStyle.Fill;
            dataGridView_Main.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridView_Main.ColumnHeadersHeight = 40;

            //Left Column Setup
            DataGridViewLinkColumn leftColumnTextBoxColumn = new DataGridViewLinkColumn();
            leftColumnTextBoxColumn.HeaderText = "Summary";
            leftColumnTextBoxColumn.DataPropertyName = "Label";
            leftColumnTextBoxColumn.ReadOnly = true;
            leftColumnTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            leftColumnTextBoxColumn.Frozen = true;
            dataGridView_Main.Columns.Add(leftColumnTextBoxColumn);

            //Right Column Setup

            //Add Columns and Headers
            AddColumns(dataGridView_Main);

            //Add Rows
            AddRows(dataGridView_Main);
        }

        private void AddColumns(DataGridView dataGridView)
        {
            Queue<MonthHeader> MonthList = MonthHeader.GenerateMonthHeaders(CurrentAccount);
            dataGridView.ScrollBars = ScrollBars.Horizontal;
            DataGridViewTextBoxColumn[] amountColumns = new DataGridViewTextBoxColumn[MonthList.Count];
            int countIndex = MonthList.Count;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            for (int i = 0; i < countIndex; i++)
            {
                MonthHeader header = MonthList.Dequeue();
                amountColumns[i] = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Amount" + i,
                    HeaderText = header.HeaderText,
                    Width = 115,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight },
                    Tag = header
                };
            }
            dataGridView.Columns.AddRange(amountColumns);
        }

        private void AddRows(DataGridView dataGridView)
        {
            List<RowData> rows = new List<RowData>();

            //Summary Rows
            List<RowData> summaryRows = RowData.GetRows(CurrentAccount);
            rows.AddRange(summaryRows);

            //Space Between Summary and Income
            //rows.Add(new RowData { Label = null });

            //Income rows
            List<Transaction> incomeTransactions = Transaction.GetTransactions("Income", CurrentAccount);
            foreach (Transaction transaction in incomeTransactions)
            {
                var existingRow = rows.FirstOrDefault(r => r.Transaction != null && r.Transaction.Description == transaction.Description);
                if (existingRow == null)
                {
                    var newRow = new RowData { Label = transaction.Description, Transaction = transaction };
                    rows.Add(newRow);
                }
            }

            //Space Between Summary and Income
            //rows.Add(new RowData { Label = null });

            //Expense rows
            int index = 0;
            List<Transaction> expenseTransactions = Transaction.GetTransactions("Expenses", CurrentAccount);
            foreach (var transaction in expenseTransactions)
            {
                var existingRow = rows.FirstOrDefault(r => r.Transaction != null && r.Transaction.Description == transaction.Description);
                if (existingRow == null)
                {
                    var newRow = new RowData { Label = transaction.Description, Transaction = transaction };
                    rows.Add(newRow);
                }
            }

            //Set the rows to the DataGrid
            dataGridView_Main.DataSource = rows;

            incomeTransactions.AddRange(expenseTransactions);

            SetTransactionAmount(incomeTransactions, dataGridView_Main);


            //Remove the grids associated with the space between Summary, Income, Expense
            dataGridView_Main.CellPainting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var rowData = dataGridView_Main.Rows[e.RowIndex].DataBoundItem as RowData;
                    if (rowData != null && rowData.Label == null)
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                        e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                        e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                    };
                };
            };
        }

        private void SetTransactionAmount(List<Transaction> allTransactions, DataGridView dataGridView_Main)
        {
            int rowIndex = -1;
            foreach (Transaction transaction in allTransactions)
            {
                foreach (DataGridViewRow row in dataGridView_Main.Rows)
                {
                    var rowDataItem = row.DataBoundItem as RowData;
                    {
                        if (rowDataItem.Label == transaction.Description)
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                }
                //Find the right column, apply the Amount to the column index and row index
                for (int i = 1; i < dataGridView_Main.ColumnCount; i++)
                {
                    var column = dataGridView_Main.Columns[i];
                    if (column.Tag is MonthHeader monthHeader)
                    {
                        if (transaction.TransactionDate >= monthHeader.StartDate && transaction.TransactionDate <= monthHeader.EndDate)
                        {
                            dataGridView_Main[i, rowIndex].Value = transaction.Amount;
                            break;

                        }
                    }
                }
            }
        }
    }
}




            //int rowIndex = rows.IndexOf(rowData);

            //if (rowIndex != -1)
            //{
            //    for (int i = 1; i < dataGridView_Main.ColumnCount; i++)
            //    {
            //        var column = dataGridView_Main.Columns[i];
            //        if (column.Tag is MonthHeader monthHeader)
            //        {
            //            if (transaction.TransactionDate >= monthHeader.StartDate && transaction.TransactionDate <= monthHeader.EndDate)
            //            {
            //                dataGridView_Main[i, rowIndex].Value = transaction.Amount;
            //                break;
            //            }
            //        }
            //    }
            //}
        

        //private void SetTransactionAmount(RowData rowData, List<RowData> rows, Transaction transaction)
        //{
        //    int rowIndex = dataGridView_Main.Rows.Add();
        //    dataGridView_Main.Rows[rowIndex].Cells[0].Value = rowData.Label;

        //    for (int i = 1; i < dataGridView_Main.ColumnCount; i++)
        //    {
        //        var column = dataGridView_Main.Columns[i];
        //        if (column.Tag is MonthHeader monthHeader)
        //        {
        //            if (transaction.TransactionDate >= monthHeader.StartDate && transaction.TransactionDate <= monthHeader.EndDate)
        //            {
        //                dataGridView_Main.Rows[rowIndex].Cells[i].Value = transaction.Amount;
        //            }
        //            else
        //            {
        //                dataGridView_Main.Rows[rowIndex].Cells[i].Value = DBNull.Value;
        //            }
        //        }
        //    }
        //}


