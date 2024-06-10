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
            dataGridView_Main.Columns.Add(leftColumnTextBoxColumn);

            createAmountColumns(dataGridView_Main);

            List<Summary> summaryDatasource = Summary.SetSummary(CurrentAccount);
            dataGridView_Main.DataSource = summaryDatasource;
            
        }

        private void createAmountColumns(DataGridView dataGridView)
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
                    DataPropertyName = "Amount",
                    HeaderText = header.HeaderText,
                    Width = 100,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight }
                };
            }
            dataGridView.Columns.AddRange(amountColumns);
        }
    }
}
