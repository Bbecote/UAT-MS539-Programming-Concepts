namespace IntitialDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            progressBar_StartStop.Style = ProgressBarStyle.Marquee;
            textBox_StartStop.Text = "Start";
            textBox_StartStop.BackColor = Color.Green;
        }
        private void button_Stop_Click(object sender, EventArgs e)
        {
            progressBar_StartStop.Style = ProgressBarStyle.Blocks;
            textBox_StartStop.Text = "Stop";
            textBox_StartStop.BackColor = Color.Pink;
        }

        private void checkBox_Function_CheckedChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = checkBox_Function.Checked;
            button_Stop.Enabled = checkBox_Function.Checked;
        }

        private void button_newForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
