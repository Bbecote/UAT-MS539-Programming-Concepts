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
            dataGridView_Main.Refresh();
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
            leftColumnTextBoxColumn.Name = "Summary";
            leftColumnTextBoxColumn.DataPropertyName = "Label";
            leftColumnTextBoxColumn.ReadOnly = true;
            leftColumnTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            leftColumnTextBoxColumn.Frozen = true;
            dataGridView_Main.Columns.Add(leftColumnTextBoxColumn);

            //Right Column Setup
            
            //Add Columns and Headers
<<<<<<< HEAD
            dataGridView_Main.AutoGenerateColumns = false;
            AddColumns(dataGridView_Main);
=======
            AddColumns(dataGridView_Main) ;
>>>>>>> parent of 6983be4 (Updating transactions (not working) - issue with rowdata and not displaying values.)

            //Add Rows
            CustomRowBuilder(dataGridView_Main);
            RowData.AddRows(CurrentAccount);

            dataGridView_Main.DataSource = RowData.TransactionsList;

<<<<<<< HEAD
=======
        private void AddRows(DataGridView dataGridView)
        {
            List<RowData> rows = new List<RowData>();

            //Summary Rows
            List<RowData> summaryRows = RowData.GetRows(CurrentAccount);
            rows.AddRange(summaryRows);
            
            //Space Between Summary and Income
            rows.Add(new RowData { Label = null });
            
            //Income rows
            List<Transaction> incomeTransactions = Transaction.GetTransactions("Income", CurrentAccount);
            List<RowData> incomeRows = incomeTransactions.Select(i => new RowData { Label = i.Description, Amount = i.Amount, Transaction = i }).ToList();
            rows.AddRange(incomeRows);

            //Space Between Summary and Income
            rows.Add(new RowData { Label = null });

            //Expense rows
            List<Transaction> expenseTransactions = Transaction.GetTransactions("Expense", CurrentAccount);
            List<RowData> expenseRows = expenseTransactions.Select(i => new RowData { Label = i.Description, Amount = i.Amount, Transaction = i }).ToList();
            rows.AddRange(expenseRows);

            dataGridView_Main.DataSource = rows;

            //Remove the grids associated with the space between Summary, Income, Expense
>>>>>>> parent of 6983be4 (Updating transactions (not working) - issue with rowdata and not displaying values.)
            dataGridView_Main.CellPainting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var rowData = dataGridView_Main.Rows[e.RowIndex].DataBoundItem as RowData;
                    if (rowData != null && rowData.Description == null)
                    {
                        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                        e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                        e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                    };
                };
            };
        }

<<<<<<< HEAD
        private void CustomRowBuilder(DataGridView dataGridView_Main)
        {
            int rowIndex = dataGridView_Main.Rows.Add();
            dataGridView_Main.Rows[rowIndex].Cells["Summary"].Value = "Opening Cash";
        }

        private void AddColumns(DataGridView dataGridView)
        {
            Queue<ColumnData> ColumnDataList = ColumnData.GenerateColumnData(CurrentAccount);
            dataGridView.ScrollBars = ScrollBars.Horizontal;
            //DataGridViewTextBoxColumn[] amountColumns = new DataGridViewTextBoxColumn[ColumnDataList.Count];
            //int countIndex = ColumnDataList.Count;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (var columnData in ColumnDataList)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    HeaderText = columnData.HeaderText,
                    Width = 115,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight },
                    Tag = columnData
                };
                dataGridView.Columns.AddRange(column);
            }
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
                        if (rowDataItem.Description == transaction.Description)
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
                    if (column.Tag is ColumnData monthHeader)
                    {
                        if (transaction.TransactionDate >= monthHeader.StartDate && transaction.TransactionDate <= monthHeader.EndDate)
                        {
                            dataGridView_Main[i, rowIndex].Value = transaction.Amount;
                            dataGridView_Main.Visible = true;
                            break;
                        }
                    }
                }
            }
        }
=======
>>>>>>> parent of 6983be4 (Updating transactions (not working) - issue with rowdata and not displaying values.)
    }
}
