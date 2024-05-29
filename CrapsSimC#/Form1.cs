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
            textBox_Player0ActiveBets.Text = Player0.totalBetAmount.ToString();
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
                    updatePlayer0Text();
                    table_Player0CurrentStanding.Visible = true;
                    table_Player0Financials.Visible = true;
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
            updatePlayer0Text();
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

        private void createMiniChips(Point point, string chipName)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CrapsTable));
            chipsButton_1Mini.FlatAppearance.BorderSize = 0;
            chipsButton_1Mini.FlatStyle = FlatStyle.Flat;
            chipsButton_1Mini.Image = (Image)resources.GetObject(chipName + ".Image");
            chipsButton_1Mini.Location = point;
            chipsButton_1Mini.Name = chipName;
            chipsButton_1Mini.Size = new Size(36, 33);
            chipsButton_1Mini.TabIndex = 83;
            chipsButton_1Mini.UseVisualStyleBackColor = false;
            chipsButton_1Mini.BackColor = Color.DarkOrange;
            chipsButton_1Mini.Visible = true;
            chipsButton_1Mini.BringToFront();
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

        private void button_PassLine_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(textBox_AmountSelected.Text);
            //TODO if no player selected, output message to select a player and return.
            if (SelectedPlayer.ActiveBankroll > betAmount)
            {
                table.MakeBet(betAmount, SelectedPlayer, "PassLineBet");
                updatePlayer0Text();
                int totalBetAmount = table.getTotalBetAmount(SelectedPlayer, "PassLineBet");
                switch (totalBetAmount)
                {
                    case < 5:
                        createMiniChips(new Point(185, 460), "chipsButton_1Mini");
                        break;
                    case < 9:
                        createMiniChips(new Point(185, 460), "chipsButton_5Mini");
                        break;
                    case < 24:
                        createMiniChips(new Point(185, 460), "chipsButton_10Mini");
                        break;
                    case < 100:
                        createMiniChips(new Point(185, 460), "chipsButton_25Mini");
                        break;
                    case < 500:
                        createMiniChips(new Point(185, 460), "chipsButton_100Mini");
                        break;
                    case < 1000:
                        createMiniChips(new Point(185, 460), "chipsButton_500Mini");
                        break;
                    default:
                        createMiniChips(new Point(185, 460), "chipsButton_1000Mini");
                        break;
                }
            }
        }

        // ------- Table Functionality - Placing Bets --------//

    }
}
