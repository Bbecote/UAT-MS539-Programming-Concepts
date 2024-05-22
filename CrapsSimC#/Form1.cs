using System.Runtime.CompilerServices;

namespace CrapsSimC_
{
    public partial class form_CrapsTable : Form
    {

        CrapsTable Table = new CrapsTable();
        Dice Dice = new Dice();
        Players Player0 = new Players();
        Players Player1 = new Players();
        Players Player2 = new Players();
        Players Player3 = new Players();
        public form_CrapsTable()
        {
            InitializeComponent();
        }

        private void updatePlayer0Text()
        {
            textBox_Player0BankRoll.Text = Player0.ActiveBankroll.ToString();
            int CurrentStanding = Player0.ActiveBankroll - Player0.InitialBankroll;
            if (CurrentStanding == 0)
            {
                textBox_Player0CurrentStanding.Text = "Breaking Even";
            }
            else { textBox_Player0CurrentStanding.Text = CurrentStanding.ToString(); }
            textBox_Player0WinWalk.Text = Player0.WinWalk.ToString();
            textBox_Player0LossWalk.Text = Player0.LossWalk.ToString();
            textBox_Player0ActiveBets.Text = Player0.totalBetAmount.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_PlayerTitle1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button_Player0_Click(object sender, EventArgs e)
        {
            Form_Player0Setup editForm = new Form_Player0Setup(Player0);
            editForm.ShowDialog();
            if (Player0.Watching)
            {
                table_Player0CurrentStanding.Visible = false;
                table_Player0Financials.Visible = false;
                panel_Player0JustWatching.Visible = true;
            }
            else
            {
                panel_Player0JustWatching.Visible = false;
                Player0.ResetPlayer();
                updatePlayer0Text();
                table_Player0CurrentStanding.Visible = true;
                table_Player0Financials.Visible = true;

            }
        }

        // ------- Rolling the Dice --------//

        private void label_DICE_Click(object sender, EventArgs e)
        {
            Dice.RollDice();
            label_LastRole1.Text = Dice.LastRoll1.ToString();
            label_LastRole2.Text = Dice.LastRoll2.ToString();
        }

        private void pictureBox_dieButton_Click(object sender, EventArgs e)
        {
            Dice.RollDice();
            label_LastRole1.Text = Dice.LastRoll1.ToString();
            label_LastRole2.Text = Dice.LastRoll2.ToString();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Dice.RollDice();
            label_LastRole1.Text = Dice.LastRoll1.ToString();
            label_LastRole2.Text = Dice.LastRoll2.ToString();
        }

        private void label_ROLL_Click(object sender, EventArgs e)
        {
            Dice.RollDice();
            label_LastRole1.Text = Dice.LastRoll1.ToString();
            label_LastRole2.Text = Dice.LastRoll2.ToString();
        }
    }
}
