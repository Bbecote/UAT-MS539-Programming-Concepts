using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CrapsSimC_
{
    public partial class form_CrapsTable : Form
    {
        Dice Dice = new Dice();
        Players Player0 = new Players();
        Players Player1 = new Players();
        Players Player2 = new Players();
        Players Player3 = new Players();
        CrapsTable table;
        Players SelectedPlayer = new Players();
        int pointRoll = 0;

        public form_CrapsTable()
        {
            InitializeComponent();
            this.table = new CrapsTable(Player0, Player1, Player2, Player3);
        }

        private void UpdatePlayerText()
        {
            switch (SelectedPlayer.PlayerID)
            {
                case 0:
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
                    textBox_Player0ActiveBets.Text = Player0.totalBetAmount.ToString();
                    break;
                case 1:
                    textBox_Player1BankRoll.Text = Player1.ActiveBankroll.ToString();
                    int CurrentStanding1 = Player1.ActiveBankroll - Player1.InitialBankroll;
                    if (CurrentStanding1 == 0)
                    {
                        textBox_Player1CurrentStanding.Text = "Breaking Even";
                    }
                    else { textBox_Player1CurrentStanding.Text = CurrentStanding1.ToString(); }
                    textBox_Player1WinWalk.Text = Player1.WinWalk.ToString();
                    textBox_Player1LossWalk.Text = Player1.LossWalk.ToString();
                    textBox_Player1ActiveBets.Text = Player1.totalBetAmount.ToString();
                    textBox_Player1ActiveBets.Text = Player1.totalBetAmount.ToString();
                    break;
                case 2:
                    textBox_Player2BankRoll.Text = Player2.ActiveBankroll.ToString();
                    int CurrentStanding2 = Player2.ActiveBankroll - Player2.InitialBankroll;
                    if (CurrentStanding2 == 0)
                    {
                        textBox_Player2CurrentStanding.Text = "Breaking Even";
                    }
                    else { textBox_Player2CurrentStanding.Text = CurrentStanding2.ToString(); }
                    textBox_Player2WinWalk.Text = Player2.WinWalk.ToString();
                    textBox_Player2LossWalk.Text = Player2.LossWalk.ToString();
                    textBox_Player2ActiveBets.Text = Player2.totalBetAmount.ToString();
                    textBox_Player2ActiveBets.Text = Player2.totalBetAmount.ToString();
                    break;
                case 3:
                    textBox_Player3BankRoll.Text = Player3.ActiveBankroll.ToString();
                    int CurrentStanding3 = Player3.ActiveBankroll - Player3.InitialBankroll;
                    if (CurrentStanding3 == 0)
                    {
                        textBox_Player3CurrentStanding.Text = "Breaking Even";
                    }
                    else { textBox_Player3CurrentStanding.Text = CurrentStanding3.ToString(); }
                    textBox_Player3WinWalk.Text = Player3.WinWalk.ToString();
                    textBox_Player3LossWalk.Text = Player3.LossWalk.ToString();
                    textBox_Player3ActiveBets.Text = Player3.totalBetAmount.ToString();
                    textBox_Player3ActiveBets.Text = Player3.totalBetAmount.ToString();
                    break;


            }
        }

        // ------- Setting Up & Selecting Players --------//

        private void button_Player0_Click(object sender, EventArgs e)
        {

            if (Player0.Watching || tableLayoutPanel_Player0.BackColor == Color.Lime)
            {

                Form_Player0Setup editForm = new Form_Player0Setup(Player0);
                editForm.ShowDialog();
                if (Player0.Watching)
                {
                    tableLayoutPanel_Player0.BackColor = Color.Transparent;
                    table_Player0CurrentStanding.Visible = false;
                    table_Player0Financials.Visible = false;
                    textBox_Player0Freeplay.Visible = false;
                    panel_Player0JustWatching.Visible = true;
                }
                else
                {
                    panel_Player0JustWatching.Visible = false;
                    Player0.ResetPlayer();
                    UpdatePlayerText();
                    table_Player0CurrentStanding.Visible = true;
                    table_Player0Financials.Visible = true;
                    tableLayoutPanel_Player0.BackColor = Color.Lime;
                    SelectedPlayer = Player0;
                    if ((string)Player0.Strategy[0] == "Free Play")
                    {
                        textBox_Player0Freeplay.Visible = true;
                    }
                }
            }
            else
            {
                SelectedPlayer = Player0;
                tableLayoutPanel_Player0.BackColor = Color.Lime;
                tableLayoutPanel_Player1.BackColor = Color.Transparent;
                tableLayoutPanel_Player2.BackColor = Color.Transparent;
                tableLayoutPanel_Player3.BackColor = Color.Transparent;
                if ((string)Player0.Strategy[0] == "Free Play")
                {
                    textBox_Player0Freeplay.Visible = true;
                }
            }
        }

        // ------- Rolling the Dice --------//

        private void RollDice()
        {
            Dice.RollDice(table);
            label_LastRole1.Text = Dice.LastRoll1.ToString();
            label_LastRole2.Text = Dice.LastRoll2.ToString();
            int rollamount = Dice.LastRoll1 + Dice.LastRoll2;
            if (!table.Button)
            {
                int[] excludedValues = { 2, 3, 7, 11, 12 };
                if (!excludedValues.Contains(rollamount))
                {
                    pictureBox_Off.Visible = false;
                    switch (rollamount)
                    {
                        case 4:
                            panel_table4.Controls.Add(pictureBox_On);
                            pictureBox_On.BringToFront();
                            pictureBox_On.Location = new Point(3, 40);
                            pictureBox_On.Visible = true;
                            this.pointRoll = 4;
                            table.Button = true;
                            break;
                        case 5:
                            panel_table5.Controls.Add(pictureBox_On);
                            pictureBox_On.Location = new Point(3, 40);
                            pictureBox_On.BringToFront();
                            pictureBox_On.Visible = true;
                            this.pointRoll = 5;
                            table.Button = true;
                            break;
                        case 6:
                            panel_table6.Controls.Add(pictureBox_On);
                            pictureBox_On.Location = new Point(3, 40);
                            pictureBox_On.BringToFront();
                            pictureBox_On.Visible = true;
                            this.pointRoll = 6;
                            table.Button = true;
                            break;
                        case 8:
                            panel_table8.Controls.Add(pictureBox_On);
                            pictureBox_On.Location = new Point(3, 40);
                            pictureBox_On.BringToFront();
                            pictureBox_On.Visible = true;
                            this.pointRoll = 8;
                            table.Button = true;
                            break;
                        case 9:
                            panel_table9.Controls.Add(pictureBox_On);
                            pictureBox_On.Location = new Point(3, 40);
                            pictureBox_On.BringToFront();
                            pictureBox_On.Visible = true;
                            this.pointRoll = 9;
                            table.Button = true;
                            break;
                        case 10:
                            panel_table10.Controls.Add(pictureBox_On);
                            pictureBox_On.Location = new Point(3, 40);
                            pictureBox_On.BringToFront();
                            pictureBox_On.Visible = true;
                            this.pointRoll = 10;
                            table.Button = true;
                            break;
                    }
                }
            }
            else
            {
                if (rollamount == this.pointRoll || rollamount == 7)
                {
                    pictureBox_On.Visible = false;
                    pictureBox_Off.Visible = true;
                    table.Button = false;
                }
            }
            UpdatePlayerText();
        }

        private void label_DICE_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void pictureBox_dieButton_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            RollDice();
        }

        private void label_ROLL_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void dieButton_1_Click(object sender, EventArgs e)
        {
            RollDice();

        }


        // ------- Chip Functionality --------//
        //TODO Revisit creating dynamic objects or create an object for each play and each bet type
        //TODO add a hover over with the bet amount

        private void createMiniChips((Point point, string chipName) betDetails, bool oddsBet = false)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CrapsTable));
            ChipsButton newChipsButton = new ChipsButton();
            newChipsButton.FlatAppearance.BorderSize = 0;
            newChipsButton.FlatStyle = FlatStyle.Flat;
            newChipsButton.Image = (Image)resources.GetObject(betDetails.chipName + ".Image");
            newChipsButton.Location = betDetails.point;
            newChipsButton.Name = betDetails.chipName;
            newChipsButton.Size = new Size(36, 33);
            newChipsButton.TabIndex = 83;
            newChipsButton.UseVisualStyleBackColor = false;
            newChipsButton.BackColor = Color.DarkOrange;
            newChipsButton.Visible = true;
            this.Controls.Add(newChipsButton);
            newChipsButton.BringToFront();
            if(oddsBet)
            {
                newChipsButton.Click += newChipsButton_Click;
            }
        }

        private void UpdateTable()
        {

        }

        private async void chipsButton_1Down_Click(object sender, EventArgs e)
        {
            int amountSelected = int.Parse(textBox_AmountSelected.Text);
            chipsButton_1Down.Visible = false;
            chipsButton_1Up.Visible = true;
            if (radioButton_AddtoBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected += 1).ToString();
            }
            if (radioButton_SubtractBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected -= 1).ToString();
            }
            await Task.Delay(75);
            chipsButton_1Up.Visible = false;
            chipsButton_1Down.Visible = true;
        }

        private async void chipsButton_5Down_Click(object sender, EventArgs e)
        {
            int amountSelected = int.Parse(textBox_AmountSelected.Text);
            chipsButton_5Down.Visible = false;
            chipsButton_5Up.Visible = true;
            if (radioButton_AddtoBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected += 5).ToString();
            }
            if (radioButton_SubtractBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected -= 5).ToString();
            }
            await Task.Delay(100);
            chipsButton_5Up.Visible = false;
            chipsButton_5Down.Visible = true;
        }

        private async void chipsButton_10Down_Click(object sender, EventArgs e)
        {
            int amountSelected = int.Parse(textBox_AmountSelected.Text);
            chipsButton_10Down.Visible = false;
            chipsButton_10Up.Visible = true;
            if (radioButton_AddtoBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected += 10).ToString();
            }
            if (radioButton_SubtractBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected -= 10).ToString();
            }
            await Task.Delay(100);
            chipsButton_10Up.Visible = false;
            chipsButton_10Down.Visible = true;
        }

        private async void chipsButton_25Down_Click(object sender, EventArgs e)
        {
            int amountSelected = int.Parse(textBox_AmountSelected.Text);
            chipsButton_25Down.Visible = false;
            chipsButton_25Up.Visible = true;
            if (radioButton_AddtoBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected += 25).ToString();
            }
            if (radioButton_SubtractBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected -= 25).ToString();
            }
            await Task.Delay(100);
            chipsButton_25Up.Visible = false;
            chipsButton_25Down.Visible = true;
        }
        private async void chipsButton_100Down_Click(object sender, EventArgs e)
        {
            int amountSelected = int.Parse(textBox_AmountSelected.Text);
            chipsButton_100Down.Visible = false;
            chipsButton_100Up.Visible = true;
            if (radioButton_AddtoBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected += 100).ToString();
            }
            if (radioButton_SubtractBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected -= 100).ToString();
            }
            await Task.Delay(100);
            chipsButton_100Up.Visible = false;
            chipsButton_100Down.Visible = true;
        }
        private async void chipsButton_500Down_Click(object sender, EventArgs e)
        {
            int amountSelected = int.Parse(textBox_AmountSelected.Text);
            chipsButton_500Down.Visible = false;
            chipsButton_500Up.Visible = true;
            if (radioButton_AddtoBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected += 500).ToString();
            }
            if (radioButton_SubtractBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected -= 500).ToString();
            }
            await Task.Delay(100);
            chipsButton_500Up.Visible = false;
            chipsButton_500Down.Visible = true;
        }
        private async void chipsButton_1000Down_Click(object sender, EventArgs e)
        {
            int amountSelected = int.Parse(textBox_AmountSelected.Text);
            chipsButton_1000Down.Visible = false;
            chipsButton_1000Up.Visible = true;
            if (radioButton_AddtoBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected += 1000).ToString();
            }
            if (radioButton_SubtractBet.Checked)
            {
                textBox_AmountSelected.Text = (amountSelected -= 1000).ToString();
            }
            await Task.Delay(100);
            chipsButton_1000Up.Visible = false;
            chipsButton_1000Down.Visible = true;
        }

        private void button_ClearAmount_Click(object sender, EventArgs e)
        {
            textBox_AmountSelected.Text = 0.ToString();
        }


        // ------- Table Functionality - Placing Bets --------//

        private void button_PassLine_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "PassLineBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "PassLineBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "PassLineBet", totalBetAmount));
            }
        }

        private void button_DontPass_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "DontPassBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "DontPassBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "DontPassBet", totalBetAmount));
            }

        }

        private void button_Field_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "Field");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "Field");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "Field", totalBetAmount));
            }

        }

        private void button_DontCome_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "DontComeBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "DontComeBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "DontComeBet", totalBetAmount));
            }
        }

        private void button_COME_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "ComeBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "ComeBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "ComeBet", totalBetAmount));
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "4_PlaceBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "4_PlaceBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "4_PlaceBet", totalBetAmount));
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "5_PlaceBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "5_PlaceBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "5_PlaceBet", totalBetAmount));
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "6_PlaceBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "6_PlaceBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "6_PlaceBet", totalBetAmount));
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "8_PlaceBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "8_PlaceBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "8_PlaceBet", totalBetAmount));
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "9_PlaceBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "9_PlaceBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "9_PlaceBet", totalBetAmount));
            }
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "10_PlaceBet");
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "10_PlaceBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "10_PlaceBet", totalBetAmount));
            }
        }

        private void newChipsButton_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            if (betAmount <= 0)
            {
                MessageBox.Show("Please update the Bet Amount");
                return;
            }
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, pointRoll + "_PlaceBet"); 
                UpdatePlayerText();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, pointRoll+ "_PlaceBet");
                createMiniChips(ChipHelper.ChipPlacer(SelectedPlayer, "lineOdds", totalBetAmount));
            }
        }



    }
}
