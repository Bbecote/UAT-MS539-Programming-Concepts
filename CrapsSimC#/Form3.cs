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
        public Form_Player0Setup()
        {
            InitializeComponent();
        }

        //---------CUSTOM CODE-----------//
        //---------Player Fonts---------//
        Font playerTitleFont = new Font("Comic Sans MS", 14, FontStyle.Bold | FontStyle.Italic);
        Font playerTextItalicsFont = new Font("Comic Sans MS", 14, FontStyle.Italic);

        //---------Player Setup---------//
        List<string> bettingStrategies = new List<string> { "Free Play", "Martingale Bets on the Passline with No Odds" };
        List<string> winningsStrategies = new List<string> { "Free Play", "Martingale Bets on the Passline with No Odds" };

        private void updateNumericUpDownSettingsBankRoll(NumericUpDown numericUpDown)
        {
            numericUpDown.Minimum = 100;
            numericUpDown.Maximum = 1000;
            numericUpDown.Increment = 50;
            numericUpDown.Value = 100;
            numericUpDown.ThousandsSeparator = true;
        }

        private void updateNumericUpDownSettingsMinMax(NumericUpDown numericUpDown)
        {
            numericUpDown.Minimum = 10;
            numericUpDown.Maximum = 500;
            numericUpDown.Increment = 10;
            numericUpDown.Value = 150;
            numericUpDown.ThousandsSeparator = true;
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
            
            // ----- Player0 Character Setup ----- //
            comboBox_Player0BettingStrategy.DataSource = bettingStrategies;
            comboBox_Player0WinningsStrategy.DataSource = winningsStrategies;

            updateNumericUpDownSettingsBankRoll(numericUpDown_Player0BankRoll);
            updateNumericUpDownSettingsMinMax(numericUpDown_Player0LoseWalk);
            updateNumericUpDownSettingsMinMax(numericUpDown_Player0WinWalk);
            updateNumericUpDownSettingsMinMax(numericUpDown_Player0MaxBet);
            updateNumericUpDownSettingsMinMax(numericUpDown_Player0MinBet);

        }
    }
}
