using System.Data;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Budget
{
    public partial class Form1 : Form
    {
        List<Budget> budget = new List<Budget>();
        public Form1()
        {
            InitializeComponent();

            string budgetQuery = "select * from Budget";
            budget = GetBudgetData(budgetQuery);

            dataGridView1.DataSource = budget;
          
        }

        public List<Budget> GetBudgetData(string queryStr)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<Budget>(queryStr, new DynamicParameters());
                return output.ToList();
            }
        }

        public static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BudgetString"].ConnectionString;
        }

    }
}
