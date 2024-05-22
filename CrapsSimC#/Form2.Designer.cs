namespace CrapsSimC_
{
    partial class Form2
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
            textBox1 = new TextBox();
            label_AmountSelected = new Label();
            panel2 = new Panel();
            tableLayoutPanel16 = new TableLayoutPanel();
            textBoxWinWalk = new TextBox();
            textBox_BankRoll = new TextBox();
            textBox2 = new TextBox();
            textBox_LoseWalk = new TextBox();
            label_BankRoll = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Font = new Font("Ink Free", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1114, 384);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 53);
            textBox1.TabIndex = 48;
            // 
            // label_AmountSelected
            // 
            label_AmountSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_AmountSelected.AutoSize = true;
            label_AmountSelected.Font = new Font("Ink Free", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_AmountSelected.Location = new Point(344, 14);
            label_AmountSelected.Margin = new Padding(0);
            label_AmountSelected.Name = "label_AmountSelected";
            label_AmountSelected.Size = new Size(612, 46);
            label_AmountSelected.TabIndex = 47;
            label_AmountSelected.Text = "Welcome to Any Given Friday Night!";
            label_AmountSelected.Click += label_AmountSelected_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label_AmountSelected);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1224, 77);
            panel2.TabIndex = 69;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 4;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.76923F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.23077F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.159235F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.159235F));
            tableLayoutPanel16.Location = new Point(527, 725);
            tableLayoutPanel16.Margin = new Padding(0);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.Size = new Size(628, 98);
            tableLayoutPanel16.TabIndex = 61;
            // 
            // textBoxWinWalk
            // 
            textBoxWinWalk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxWinWalk.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxWinWalk.Location = new Point(516, 762);
            textBoxWinWalk.Name = "textBoxWinWalk";
            textBoxWinWalk.Size = new Size(101, 43);
            textBoxWinWalk.TabIndex = 54;
            // 
            // textBox_BankRoll
            // 
            textBox_BankRoll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_BankRoll.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox_BankRoll.Location = new Point(481, 515);
            textBox_BankRoll.Name = "textBox_BankRoll";
            textBox_BankRoll.Size = new Size(94, 43);
            textBox_BankRoll.TabIndex = 52;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(594, 539);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 43);
            textBox2.TabIndex = 60;
            // 
            // textBox_LoseWalk
            // 
            textBox_LoseWalk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_LoseWalk.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox_LoseWalk.Location = new Point(516, 811);
            textBox_LoseWalk.Name = "textBox_LoseWalk";
            textBox_LoseWalk.Size = new Size(101, 43);
            textBox_LoseWalk.TabIndex = 58;
            // 
            // label_BankRoll
            // 
            label_BankRoll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_BankRoll.AutoSize = true;
            label_BankRoll.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_BankRoll.Location = new Point(3, 0);
            label_BankRoll.Name = "label_BankRoll";
            label_BankRoll.Size = new Size(143, 36);
            label_BankRoll.TabIndex = 51;
            label_BankRoll.Text = "Bank Roll:";
            label_BankRoll.Click += label_BankRoll_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(726, 284);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(479, 23);
            comboBox1.TabIndex = 70;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(835, 214);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(255, 46);
            label1.TabIndex = 48;
            label1.Text = "Game Options";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(277, 696);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 75;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_BankRoll);
            panel1.Location = new Point(12, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 506);
            panel1.TabIndex = 76;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 989);
            Controls.Add(panel1);
            Controls.Add(textBox_BankRoll);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox_LoseWalk);
            Controls.Add(textBox2);
            Controls.Add(textBoxWinWalk);
            Controls.Add(tableLayoutPanel16);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label_AmountSelected;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel16;
        private TextBox textBoxWinWalk;
        private TextBox textBox_BankRoll;
        private TextBox textBox2;
        private TextBox textBox_LoseWalk;
        private Label label_BankRoll;
        private ComboBox comboBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}