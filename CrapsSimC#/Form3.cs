using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsSimC_
{
    public partial class Form_Player0Setup : Form
    {
        private Players CurrentPlayer = new Players();

        //---------Player Fonts---------//
        private int maxBankroll = 1000;
        private int winLossWalkMax = 500;

        public Form_Player0Setup(Players Player)
        {
            this.CurrentPlayer = Player;
            InitializeComponent();
        }

        //---------Player Fonts---------//
        Font playerTitleFont = new Font("Comic Sans MS", 14, FontStyle.Bold | FontStyle.Italic);
        Font playerTextItalicsFont = new Font("Comic Sans MS", 14, FontStyle.Italic);

        //---------Player Setup---------//
        List<string> bettingStrategies = new List<string> { "Free Play", "Martingale Bets on the Passline with No Odds" };
        List<string> winningsStrategies = new List<string> { "Free Play", "Martingale Bets on the Passline with No Odds" };

        private void updateNumericUpDownSettingsBankRoll(NumericUpDown numericUpDown)
        {
            //numericUpDown.ThousandsSeparator = true;
            numericUpDown.Minimum = 100;
            numericUpDown.Maximum = 10000;
            numericUpDown.Increment = 50;
            numericUpDown.Value = 300;

        }

        private void updateNumericUpDownSettingsMinMax(NumericUpDown numericUpDown)
        {
            //numericUpDown.ThousandsSeparator = true;
            numericUpDown.Minimum = 10;
            numericUpDown.Maximum = 5000;
            numericUpDown.Increment = 10;
            numericUpDown.Value = 500;
        }

        List<string> numericUpDownSettings = new List<string> { };

        private void label_BankRoll_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label_MinBet_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            // ----- Player0 Character Input Setup ----- //
            comboBox_Player0BettingStrategy.DataSource = bettingStrategies;
            comboBox_Player0WinningsStrategy.DataSource = winningsStrategies;

            updateNumericUpDownSettingsBankRoll(numericUpDown_Player0BankRoll);
            updateNumericUpDownSettingsMinMax(numericUpDown_Player0LoseWalk);
            updateNumericUpDownSettingsMinMax(numericUpDown_Player0WinWalk);
            updateNumericUpDownSettingsMinMax(numericUpDown_Player0MaxBet);
            updateNumericUpDownSettingsMinMax(numericUpDown_Player0MinBet);
            numericUpDown_Player0MinBet.Value = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentPlayer.Watching = false;
            CurrentPlayer.InitialBankroll = int.Parse(numericUpDown_Player0BankRoll.Text);
            CurrentPlayer.Strategy[0] = comboBox_Player0BettingStrategy.SelectedItem.ToString();
            CurrentPlayer.Strategy[1] = comboBox_Player0WinningsStrategy.SelectedItem.ToString();
            CurrentPlayer.Strategy[2] = int.Parse(numericUpDown_Player0MinBet.Text);
            CurrentPlayer.Strategy[3] = int.Parse(numericUpDown_Player0MaxBet.Text);
            CurrentPlayer.WinWalk = int.Parse(numericUpDown_Player0WinWalk.Text);
            CurrentPlayer.LossWalk = int.Parse(numericUpDown_Player0LoseWalk.Text);
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentPlayer.Watching = true;
            this.Close();
            this.Dispose();
        }

        private void numericUpDown_Player0BankRoll_Validating(object sender, CancelEventArgs e)
        {
            int amount = (int)numericUpDown_Player0BankRoll.Value;
            if (amount > maxBankroll)
            {
                errorProvider.SetError(numericUpDown_Player0BankRoll, $"Bankroll cannot exceed {maxBankroll}. Please enter a valid amount.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(numericUpDown_Player0BankRoll, "");
            }
        }

        private void numericUpDown_Player0MinBet_Validating(object sender, CancelEventArgs e)
        {
            int amount = (int)numericUpDown_Player0MinBet.Value;
            if (amount > winLossWalkMax)
            {
                errorProvider.SetError(numericUpDown_Player0MinBet, $"Bankroll cannot exceed {winLossWalkMax}. Please enter a valid amount.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(numericUpDown_Player0MinBet, "");
            }
        }
    }
}
