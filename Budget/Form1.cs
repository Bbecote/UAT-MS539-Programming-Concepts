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

        public Form1()
        {
            InitializeComponent();
            SetupDataGridViews();
            //PopulateDataGridView();
        }

        private void SetupDataGridViews()
        {
            //TODO setup DataGridView properties and event handlers
            //TODO resize the DataGridView to the width and length based on columns and rows

            //-----Summary DataGridView-----//
            dataGridView = new DataGridView();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.LemonChiffon;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(430, 55);
            dataGridView.Name = "dataGridView_Summary";
            int totalWidth = dataGridView.RowHeadersWidth;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                totalWidth += column.Width;
            }

            int totalHeight = dataGridView.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                totalHeight += row.Height;
            }

            dataGridView.Size = new Size(totalWidth-450, totalHeight-165);
            dataGridView.TabIndex = 2;

            DataGridViewTextBoxColumn leftColumnTextBoxColumn = new DataGridViewTextBoxColumn();
            leftColumnTextBoxColumn.HeaderText = "Summary";
            leftColumnTextBoxColumn.DataPropertyName = "Label";
            leftColumnTextBoxColumn.ReadOnly = true;
            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = "Amount";
            //amountColumn.HeaderText = "Amount";
            dataGridView.Columns.Add(amountColumn);
            dataGridView.Columns.Insert(0, leftColumnTextBoxColumn);
            BindingList<Summary> datasource = Summary.SetSummary("NavyFed");
            dataGridView.DataSource = datasource;
            if (dataGridView.Columns.Count > 0 && string.IsNullOrEmpty(dataGridView.Columns[0].DataPropertyName))
            {
                dataGridView.Columns.RemoveAt(0);
            }

            this.Controls.Add(dataGridView);


            ////-----Income DataGridView---- -//
            //dataGridView = new DataGridView();
            //dataGridView.AutoGenerateColumns = false;
            //dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //dataGridView.BackgroundColor = Color.Red;
            //dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dataGridView.Location = new Point(430, 300);
            //dataGridView.Name = "dataGridView_Income";
            //dataGridView.Size = new Size(1150, 220);
            //dataGridView.TabIndex = 2;

            //dataGridView.CellContentClick += dataGridView_CellContentClick;
            //this.Controls.Add(dataGridView);

            ////-----Expense DataGridView-----//
            //dataGridView = new DataGridView();
            //dataGridView.AutoGenerateColumns = false;
            //dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //dataGridView.BackgroundColor = Color.Yellow;
            //dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dataGridView.Location = new Point(430, 600);
            //dataGridView.Name = "dataGridView_Expenses";
            //dataGridView.Size = new Size(1150, 220);
            //dataGridView.TabIndex = 2;

            //dataGridView.CellContentClick += dataGridView_CellContentClick;
            //this.Controls.Add(dataGridView);


            ////TODO Create and configure remaining columns
            ////Code for Linkable Text
            //DataGridViewLinkColumn descriptionColumn = new DataGridViewLinkColumn();
            //descriptionColumn.HeaderText = "Transaction Name";
            //descriptionColumn.DataPropertyName = "Description";
            //descriptionColumn.ActiveLinkColor = Color.Blue;
            //descriptionColumn.LinkBehavior = LinkBehavior.SystemDefault;
            //descriptionColumn.TrackVisitedState = false;
            //descriptionColumn.VisitedLinkColor = Color.Blue;
            //dataGridView.Columns.Add(descriptionColumn);
        }

        //-------Resize the DataGridView-----//

        private void ResizeDataGridView()
        {
            int totalWidth = dataGridView.RowHeadersWidth;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                totalWidth += column.Width;
            }

            int totalHeight = dataGridView.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                totalHeight += row.Height;
            }

            dataGridView.ClientSize = new Size(totalWidth, totalHeight);
        }






        //private List<string> GetLeftColumnLabels()
        //{
        //    List<string> leftColumnLabels = new List<string>
        //    {
        //        "Opening Cash",
        //        "Total Income",
        //        "Total Expenditures",
        //        "Current Balance",
        //        "Net Cash Flow",
        //        "Ending Balance",
        //    };

        //    string query = "SELECT c.CategoryName, t.TransactionType " + "FROM TransactionList t " + "JOIN CategoryList c ON t.CategoryID = c.CategoryID " + "GROUP BY c.CategoryName, t.TransactionType";

        //    using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var transactionRows = connection.Query<(string CategoryName, string TransactionType)>(query);

        //        foreach (var row in transactionRows)
        //        {
        //            string category = row.CategoryName;
        //            string transactionType = row.TransactionType;

        //            leftColumnLabels.Add($"{category}");
        //        }
        //    }
        //    return leftColumnLabels;
        //}


















        //        private void PopulateDataGridView()
        //    {
        //        string query = "SELECT c.CategoryName, t.TransactionType, t.Description, t.TransactionDate, t.URL " + "FROM TransactionList t " + "JOIN CategoryList c ON t.CategoryID = c.CategoryID " + "ORDER BY c.CategoryName, t.TransactionDate";

        //        Dictionary<string, List<TransactionRow>> transactionRows = GetTransactionRowsFromDatabase(query);

        //        List<Transaction> datasource = new List<Transaction>();
        //        List<string> leftColumnLabels = GetLeftColumnLabels();

        //        int labelIndex = 0;

        //        foreach (var category in transactionRows.Keys)
        //        {
        //            datasource.Add(new Transaction
        //            {
        //                LeftColumnText = (labelIndex < leftColumnLabels.Count) ? leftColumnLabels[labelIndex] : "",
        //                CategoryName = category,
        //                Description = "",
        //                TransactionType = "",
        //                TransactionDate = DateTime.MinValue,
        //                URL = ""
        //            });

        //            labelIndex++;

        //            foreach (var transactionRow in transactionRows[category])
        //            {
        //                datasource.Add(new Transaction
        //                {
        //                    LeftColumnText = transactionRow.Description,
        //                    CategoryName = "",
        //                    //Description = transactionRow.Description,
        //                    TransactionType = transactionRow.TransactionType,
        //                    TransactionDate = transactionRow.TransactionDate, //.ToString("yyyy-MM-dd"),
        //                    URL = transactionRow.URL
        //                });
        //            }
        //        }
        //        dataGridView.DataSource = datasource;
        //    }



        //        //int rowIndex = 0;
        //        //foreach (string rowText in summaryColumn)
        //        //{
        //        //    Label label_Column0 = new Label();
        //        //    label_Column0.Text = rowText;
        //        //    label_Column0.AutoSize = true;
        //        //    label_Column0.Location = new Point(10, 30 + (rowIndex * 20));
        //        //    this.Controls.Add(label_Column0);
        //        //    rowIndex++;
        //        //}


        //    private Dictionary<string, List<TransactionRow>> GetTransactionRowsFromDatabase(string query)
        //    {
        //        Dictionary<string, List<TransactionRow>> transactionRows = new Dictionary<string, List<TransactionRow>>();

        //        using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
        //        {
        //            var result = connection.Query<(string CategoryName, string TransactionType, string Description, DateTime TransactionDate, string URL)>(query);

        //            foreach (var row in result)
        //            {
        //                string category = row.CategoryName;
        //                TransactionRow transactionRow = new TransactionRow
        //                {
        //                    TransactionType = row.TransactionType,
        //                    Description = row.Description,
        //                    TransactionDate = row.TransactionDate,
        //                    URL = row.URL
        //                };

        //                if (!transactionRows.ContainsKey(category))
        //                {
        //                    transactionRows[category] = new List<TransactionRow>();
        //                }
        //                transactionRows[category].Add(transactionRow);
        //            }
        //        }
        //        return transactionRows;
        //    }

        //    public static string LoadConnectionString(string id = "Default")
        //    {
        //        return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        //    }

        //    private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //    {
        //        if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["Description"].Index)
        //        {
        //            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
        //            string url = row.Cells["URL"].Value?.ToString();

        //            if (!string.IsNullOrEmpty(url))
        //            {
        //                try
        //                {
        //                    Process.Start(url);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show($"Error opening URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        }
        //    }

        //    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //    {

        //    }
        //}

        //internal class TransactionRow
        //{
        //    public string TransactionType { get; set; }
        //    public string Description { get; set; }
        //    public DateTime TransactionDate { get; set; }
        //    public string URL { get; set; }
        //}
    }
}
