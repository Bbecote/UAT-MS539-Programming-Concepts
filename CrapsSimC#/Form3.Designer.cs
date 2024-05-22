using System.Threading.Tasks;

namespace CrapsSimC_
{
    partial class Form_Player0Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Player0Setup));
            label2 = new Label();
            label_MinBet = new Label();
            label_WinningsStrategy = new Label();
            label_BettingStrategy = new Label();
            label_LoseWalk = new Label();
            label_WinWalk = new Label();
            tableLayoutPanel18 = new TableLayoutPanel();
            label_PlayerTitle1 = new Label();
            pictureBox1 = new PictureBox();
            label_BankRoll = new Label();
            richTextBox_Sam = new RichTextBox();
            comboBox_Player0BettingStrategy = new ComboBox();
            numericUpDown_Player0BankRoll = new NumericUpDown();
            comboBox_Player0WinningsStrategy = new ComboBox();
            numericUpDown_Player0MinBet = new NumericUpDown();
            numericUpDown_Player0MaxBet = new NumericUpDown();
            numericUpDown_Player0WinWalk = new NumericUpDown();
            numericUpDown_Player0LoseWalk = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            errorProvider = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            tableLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0BankRoll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0MinBet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0MaxBet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0WinWalk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0LoseWalk).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(133, 36);
            label2.TabIndex = 80;
            label2.Text = "Max Bet:";
            // 
            // label_MinBet
            // 
            label_MinBet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_MinBet.AutoSize = true;
            label_MinBet.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_MinBet.Location = new Point(10, 7);
            label_MinBet.Name = "label_MinBet";
            label_MinBet.Size = new Size(126, 36);
            label_MinBet.TabIndex = 79;
            label_MinBet.Text = "Min Bet:";
            label_MinBet.Click += label_MinBet_Click;
            // 
            // label_WinningsStrategy
            // 
            label_WinningsStrategy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_WinningsStrategy.AutoSize = true;
            label_WinningsStrategy.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_WinningsStrategy.Location = new Point(3, 95);
            label_WinningsStrategy.Name = "label_WinningsStrategy";
            label_WinningsStrategy.Size = new Size(260, 36);
            label_WinningsStrategy.TabIndex = 78;
            label_WinningsStrategy.Text = "Winnings Strategy:";
            // 
            // label_BettingStrategy
            // 
            label_BettingStrategy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_BettingStrategy.AutoSize = true;
            label_BettingStrategy.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_BettingStrategy.Location = new Point(9, 51);
            label_BettingStrategy.Name = "label_BettingStrategy";
            label_BettingStrategy.Size = new Size(254, 36);
            label_BettingStrategy.TabIndex = 77;
            label_BettingStrategy.Text = "Betting Strategy:";
            // 
            // label_LoseWalk
            // 
            label_LoseWalk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_LoseWalk.AutoSize = true;
            label_LoseWalk.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_LoseWalk.Location = new Point(3, 50);
            label_LoseWalk.Name = "label_LoseWalk";
            label_LoseWalk.Size = new Size(150, 36);
            label_LoseWalk.TabIndex = 76;
            label_LoseWalk.Text = "Lose Walk:";
            // 
            // label_WinWalk
            // 
            label_WinWalk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_WinWalk.AutoSize = true;
            label_WinWalk.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_WinWalk.Location = new Point(19, 7);
            label_WinWalk.Name = "label_WinWalk";
            label_WinWalk.Size = new Size(134, 36);
            label_WinWalk.TabIndex = 75;
            label_WinWalk.Text = "Win Walk:";
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 1;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel18.Controls.Add(label_PlayerTitle1, 0, 0);
            tableLayoutPanel18.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel18.Location = new Point(55, 86);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 2;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0872478F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 86.91275F));
            tableLayoutPanel18.Size = new Size(220, 352);
            tableLayoutPanel18.TabIndex = 81;
            // 
            // label_PlayerTitle1
            // 
            label_PlayerTitle1.Anchor = AnchorStyles.Bottom;
            label_PlayerTitle1.AutoSize = true;
            label_PlayerTitle1.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_PlayerTitle1.Location = new Point(74, 10);
            label_PlayerTitle1.Margin = new Padding(0);
            label_PlayerTitle1.Name = "label_PlayerTitle1";
            label_PlayerTitle1.Size = new Size(71, 36);
            label_PlayerTitle1.TabIndex = 64;
            label_PlayerTitle1.Text = "Sam";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(3, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 300);
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // label_BankRoll
            // 
            label_BankRoll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_BankRoll.AutoSize = true;
            label_BankRoll.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_BankRoll.Location = new Point(120, 7);
            label_BankRoll.Name = "label_BankRoll";
            label_BankRoll.Size = new Size(143, 36);
            label_BankRoll.TabIndex = 51;
            label_BankRoll.Text = "Bank Roll:";
            label_BankRoll.Click += label_BankRoll_Click;
            // 
            // richTextBox_Sam
            // 
            richTextBox_Sam.BackColor = Color.White;
            richTextBox_Sam.BorderStyle = BorderStyle.None;
            richTextBox_Sam.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_Sam.ForeColor = SystemColors.WindowText;
            richTextBox_Sam.Location = new Point(370, 21);
            richTextBox_Sam.Name = "richTextBox_Sam";
            richTextBox_Sam.ReadOnly = true;
            richTextBox_Sam.Size = new Size(925, 451);
            richTextBox_Sam.TabIndex = 0;
            richTextBox_Sam.Text = resources.GetString("richTextBox_Sam.Text");
            // 
            // comboBox_Player0BettingStrategy
            // 
            comboBox_Player0BettingStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Player0BettingStrategy.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_Player0BettingStrategy.FormattingEnabled = true;
            comboBox_Player0BettingStrategy.Location = new Point(269, 46);
            comboBox_Player0BettingStrategy.Name = "comboBox_Player0BettingStrategy";
            comboBox_Player0BettingStrategy.Size = new Size(571, 38);
            comboBox_Player0BettingStrategy.TabIndex = 88;
            // 
            // numericUpDown_Player0BankRoll
            // 
            numericUpDown_Player0BankRoll.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_Player0BankRoll.Location = new Point(269, 3);
            numericUpDown_Player0BankRoll.Name = "numericUpDown_Player0BankRoll";
            numericUpDown_Player0BankRoll.Size = new Size(117, 37);
            numericUpDown_Player0BankRoll.TabIndex = 89;
            numericUpDown_Player0BankRoll.Validating += numericUpDown_Player0BankRoll_Validating;
            // 
            // comboBox_Player0WinningsStrategy
            // 
            comboBox_Player0WinningsStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Player0WinningsStrategy.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_Player0WinningsStrategy.FormattingEnabled = true;
            comboBox_Player0WinningsStrategy.Location = new Point(269, 90);
            comboBox_Player0WinningsStrategy.Name = "comboBox_Player0WinningsStrategy";
            comboBox_Player0WinningsStrategy.Size = new Size(571, 38);
            comboBox_Player0WinningsStrategy.TabIndex = 90;
            // 
            // numericUpDown_Player0MinBet
            // 
            numericUpDown_Player0MinBet.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_Player0MinBet.Location = new Point(142, 3);
            numericUpDown_Player0MinBet.Name = "numericUpDown_Player0MinBet";
            numericUpDown_Player0MinBet.Size = new Size(117, 37);
            numericUpDown_Player0MinBet.TabIndex = 91;
            toolTip1.SetToolTip(numericUpDown_Player0MinBet, "Sam will bet the minimum you set here and increase/decrease bets based on the strategies you set above!");
            numericUpDown_Player0MinBet.Validating += numericUpDown_Player0MinBet_Validating;
            // 
            // numericUpDown_Player0MaxBet
            // 
            numericUpDown_Player0MaxBet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown_Player0MaxBet.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_Player0MaxBet.Location = new Point(159, 3);
            numericUpDown_Player0MaxBet.Name = "numericUpDown_Player0MaxBet";
            numericUpDown_Player0MaxBet.Size = new Size(117, 37);
            numericUpDown_Player0MaxBet.TabIndex = 92;
            toolTip1.SetToolTip(numericUpDown_Player0MaxBet, "The default of \"0\" will ensure Sam can continue playing until she runs out of money or the House is beat!");
            // 
            // numericUpDown_Player0WinWalk
            // 
            numericUpDown_Player0WinWalk.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_Player0WinWalk.Location = new Point(142, 46);
            numericUpDown_Player0WinWalk.Name = "numericUpDown_Player0WinWalk";
            numericUpDown_Player0WinWalk.Size = new Size(117, 37);
            numericUpDown_Player0WinWalk.TabIndex = 93;
            toolTip1.SetToolTip(numericUpDown_Player0WinWalk, "This sets a hard maximum limit on your betting strategy! The default of \"0\" will allow Sam to bet according to the Strategy you select up to her current bankroll.");
            // 
            // numericUpDown_Player0LoseWalk
            // 
            numericUpDown_Player0LoseWalk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown_Player0LoseWalk.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_Player0LoseWalk.Location = new Point(159, 46);
            numericUpDown_Player0LoseWalk.Name = "numericUpDown_Player0LoseWalk";
            numericUpDown_Player0LoseWalk.Size = new Size(117, 37);
            numericUpDown_Player0LoseWalk.TabIndex = 94;
            toolTip1.SetToolTip(numericUpDown_Player0LoseWalk, "The default of \"0\" will ensure Sam can continue playing until she runs out of money or the House is beat!");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label_BankRoll, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBox_Player0BettingStrategy, 1, 1);
            tableLayoutPanel1.Controls.Add(label_WinningsStrategy, 0, 2);
            tableLayoutPanel1.Controls.Add(label_BettingStrategy, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBox_Player0WinningsStrategy, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown_Player0BankRoll, 1, 0);
            tableLayoutPanel1.Location = new Point(23, 494);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(840, 131);
            tableLayoutPanel1.TabIndex = 95;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(numericUpDown_Player0MinBet, 1, 0);
            tableLayoutPanel2.Controls.Add(numericUpDown_Player0WinWalk, 1, 1);
            tableLayoutPanel2.Controls.Add(label_MinBet, 0, 0);
            tableLayoutPanel2.Location = new Point(146, 628);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(281, 86);
            tableLayoutPanel2.TabIndex = 96;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(numericUpDown_Player0MaxBet, 1, 0);
            tableLayoutPanel3.Controls.Add(numericUpDown_Player0LoseWalk, 1, 1);
            tableLayoutPanel3.Controls.Add(label_WinWalk, 0, 0);
            tableLayoutPanel3.Controls.Add(label_LoseWalk, 0, 1);
            tableLayoutPanel3.Location = new Point(560, 628);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(278, 86);
            tableLayoutPanel3.TabIndex = 97;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(976, 589);
            button1.Name = "button1";
            button1.Size = new Size(135, 50);
            button1.TabIndex = 98;
            button1.Text = "Just Watching";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(976, 513);
            button2.Name = "button2";
            button2.Size = new Size(135, 50);
            button2.TabIndex = 99;
            button2.Text = "Let's Go!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form_Player0Setup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1307, 771);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(richTextBox_Sam);
            Controls.Add(tableLayoutPanel18);
            ForeColor = Color.Black;
            MinimizeBox = false;
            Name = "Form_Player0Setup";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += Form3_Load;
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0BankRoll).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0MinBet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0MaxBet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0WinWalk).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Player0LoseWalk).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label_MinBet;
        private Label label_WinningsStrategy;
        private Label label_BettingStrategy;
        private Label label_LoseWalk;
        private Label label_WinWalk;
        private TableLayoutPanel tableLayoutPanel18;
        private Label label_PlayerTitle1;
        private Panel panel1;
        private Label label_BankRoll;
        private RichTextBox richTextBox_Sam;
        private ComboBox comboBox_Player0BettingStrategy;
        private NumericUpDown numericUpDown_Player0BankRoll;
        private ComboBox comboBox_Player0WinningsStrategy;
        private NumericUpDown numericUpDown_Player0MinBet;
        private NumericUpDown numericUpDown_Player0MaxBet;
        private NumericUpDown numericUpDown_Player0WinWalk;
        private NumericUpDown numericUpDown_Player0LoseWalk;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private ErrorProvider errorProvider;
        private ToolTip toolTip1;
    }
}