using System.Data;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace DBApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateDatabase();
            LoadData();
        }

        private void CreateDatabase()
        {
            string dbPath = Path.Combine(Application.StartupPath, "DemoDatabase.sqlite");
            if (!File.Exists(dbPath))
            {
                MessageBox.Show("No database yet");
                SQLiteConnection.CreateFile(dbPath);
                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();
                    string sql = "CREATE TABLE Students (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Age INTEGER)";
                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Database already created");
            }
        }

        private void AddRecord(string name, int age)
        {
            using (var connection = new SQLiteConnection("Data Source =DemoDatabase.sqlite;Version=3"))
            {
                connection.Open();
                string sql = "INSERT INTO Students (Name, Age) VALUES (@Name, @Age)";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Age", age);
                command.ExecuteNonQuery();
            }
        }

        private void LoadData()
        {
            using (var connection = new SQLiteConnection("Data Source=DemoDatabase.sqlite;Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Students";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void UpdateRecord(int id, string name, int age)
        {
            using (var connection = new SQLiteConnection("Data Source=DemoDatabase.sqlite;Version=3;"))
            {
                connection.Open();
                string sql = "UPDATE Students SET Name = @Name, Age = @Age WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Age", age);
                command.ExecuteNonQuery();
            }
        }

        private void DeleteRecord(int id)
        {
            using (var connection = new SQLiteConnection("Data Source=DemoDatabase.sqlite;Version=3;"))
            {
                connection.Open();
                string sql = "DELETE FROM Students WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text.ToString();
            int age = int.Parse(textBox_Age.Text);

            AddRecord(name, age);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                string name = textBox_Name.Text;
                if (int.TryParse(textBox_Age.Text, out int age))
                {
                    UpdateRecord(id, name, age);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please enter a valid age.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                DeleteRecord(id);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
