using System.Transactions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BudgetApp
{
    public partial class Form1 : Form
    {
        Account CurrentAccount;
        public Form1()
        {
            this.CurrentAccount = DBManager.GetAccountFromDatabase("NavyFed");
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
            leftColumnTextBoxColumn.Name = "Summary";
            leftColumnTextBoxColumn.DataPropertyName = "Description";
            leftColumnTextBoxColumn.ReadOnly = true;
            leftColumnTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            leftColumnTextBoxColumn.Frozen = true;
            dataGridView_Main.Columns.Add(leftColumnTextBoxColumn);

            //Right Column Setup

            //Add Columns and Headers
            
            dataGridView_Main.AutoGenerateColumns = false;
            AddColumns(dataGridView_Main, CurrentAccount);
            dataGridView_Main.DataSource = CurrentAccount.TransactionsDataSource;

            //Add Rows

            //
        }

        private void dataGridView_MainCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == amountColumn.Index) // Check if it's the target column
            string date = "6/1/2024 12:00:00 AM";
            //e.Value = CurrentAccount.TransactionsDataSource[0].Transactions[date].ToString("C");
            e.Value = date;
        }

        private void AddColumns(DataGridView dataGridView, Account currentAccount)
        {
            Queue<ColumnData> ColumnDataList = ColumnData.GenerateColumnData(CurrentAccount);
            dataGridView.ScrollBars = ScrollBars.Horizontal;
            //DataGridViewTextBoxColumn[] amountColumns = new DataGridViewTextBoxColumn[ColumnDataList.Count];
            //int countIndex = ColumnDataList.Count;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Summary" });
            foreach (var columnData in ColumnDataList)
            {
                //TransactionsData.Date = date,
                var column = new DataGridViewTextBoxColumn
                {
                    HeaderText = columnData.HeaderText,
                    Width = 115,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "C" },
                    Tag = columnData,
                    DataPropertyName = "TestValue"
                };
                dataGridView.Columns.AddRange(column);
            }
        }
    }
}