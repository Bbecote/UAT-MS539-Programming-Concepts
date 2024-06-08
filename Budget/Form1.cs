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
        List<Account> budget = new List<Account>();
        public Form1()
        {
            InitializeComponent();

            string budgetQuery = "select * from Account";  //Dapper functionality
            budget = GetBudgetData(budgetQuery);

            dataGridView1.DataSource = budget;

        }

        //Will Move to the Database Class
        public List<Account> GetBudgetData(string queryStr)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<Account>(queryStr, new DynamicParameters());
                return output.ToList();
            }
        }

        //Will move to the database Class
        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            //Sets Form1 to full screen - to set to a percentage, change 1 to .75 or .5 as applicable.
            this.Size = new System.Drawing.Size(Convert.ToInt32(1 * workingRectangle.Width), Convert.ToInt32(1 * workingRectangle.Height));
            this.Location = new System.Drawing.Point(0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
