namespace Budget
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Left = new Panel();
            panel2 = new Panel();
            button_Accounts = new Button();
            button_View = new Button();
            button_Settings = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label_AccountType = new Label();
            label_AccountName = new Label();
            panel_Main = new Panel();
            dataGridView_Main = new DataGridView();
            panel_Left.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Main).BeginInit();
            SuspendLayout();
            // 
            // panel_Left
            // 
            panel_Left.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_Left.BackColor = SystemColors.Highlight;
            panel_Left.Controls.Add(panel2);
            panel_Left.Controls.Add(panel1);
            panel_Left.Controls.Add(pictureBox1);
            panel_Left.Controls.Add(label_AccountType);
            panel_Left.Controls.Add(label_AccountName);
            panel_Left.Location = new Point(0, 0);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(432, 1045);
            panel_Left.TabIndex = 1;
            panel_Left.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_Accounts);
            panel2.Controls.Add(button_View);
            panel2.Controls.Add(button_Settings);
            panel2.Location = new Point(176, 343);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 314);
            panel2.TabIndex = 9;
            // 
            // button_Accounts
            // 
            button_Accounts.BackColor = Color.Transparent;
            button_Accounts.Location = new Point(3, 3);
            button_Accounts.Name = "button_Accounts";
            button_Accounts.Size = new Size(197, 43);
            button_Accounts.TabIndex = 10;
            button_Accounts.Text = "Accounts";
            button_Accounts.UseVisualStyleBackColor = false;
            // 
            // button_View
            // 
            button_View.BackColor = Color.Transparent;
            button_View.Location = new Point(3, 127);
            button_View.Name = "button_View";
            button_View.Size = new Size(197, 43);
            button_View.TabIndex = 9;
            button_View.Text = "View";
            button_View.UseVisualStyleBackColor = false;
            // 
            // button_Settings
            // 
            button_Settings.BackColor = Color.Transparent;
            button_Settings.Location = new Point(3, 266);
            button_Settings.Name = "button_Settings";
            button_Settings.Size = new Size(197, 43);
            button_Settings.TabIndex = 8;
            button_Settings.Text = "Settings";
            button_Settings.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(29, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 3);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(26, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 89);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label_AccountType
            // 
            label_AccountType.AutoSize = true;
            label_AccountType.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_AccountType.ForeColor = SystemColors.GradientActiveCaption;
            label_AccountType.Location = new Point(167, 108);
            label_AccountType.Name = "label_AccountType";
            label_AccountType.Size = new Size(131, 20);
            label_AccountType.TabIndex = 1;
            label_AccountType.Text = "Account Type";
            // 
            // label_AccountName
            // 
            label_AccountName.AutoSize = true;
            label_AccountName.Font = new Font("Mongolian Baiti", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_AccountName.ForeColor = SystemColors.ButtonHighlight;
            label_AccountName.Location = new Point(167, 70);
            label_AccountName.Name = "label_AccountName";
            label_AccountName.Size = new Size(190, 29);
            label_AccountName.TabIndex = 0;
            label_AccountName.Text = "Account Name";
            // 
            // panel_Main
            // 
            panel_Main.Controls.Add(dataGridView_Main);
            panel_Main.Location = new Point(438, 12);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1411, 1000);
            panel_Main.TabIndex = 2;
            // 
            // dataGridView_Main
            // 
            dataGridView_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Main.Location = new Point(0, 0);
            dataGridView_Main.Name = "dataGridView_Main";
            dataGridView_Main.Size = new Size(1411, 997);
            dataGridView_Main.TabIndex = 0;
            //dataGridView_Main.CellContentClick += dataGridView_Main_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel_Main);
            Controls.Add(panel_Left);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel_Left.ResumeLayout(false);
            panel_Left.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Main).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Left;
        private Label label_AccountType;
        private Label label_AccountName;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button_View;
        private Button button_Settings;
        private Button button_Accounts;
        private DataGridView DataGridView_Summary;
        private Panel panel_Income;
        private Panel panel_Expenses;
        private Panel panel_Budget;
        private Panel panel_Main;
        private DataGridView dataGridView_Main;
        //private Panel panel_Budget;
    }
}
