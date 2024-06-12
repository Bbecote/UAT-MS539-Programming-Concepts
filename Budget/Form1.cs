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
            AddColumns(dataGridView_Main) ;

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

    }
}
