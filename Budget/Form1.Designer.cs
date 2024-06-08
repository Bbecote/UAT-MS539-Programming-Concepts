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
            dataGridView1 = new DataGridView();
            panel_Left = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label_AccountType = new Label();
            label_AccountName = new Label();
            button_Settings = new Button();
            panel2 = new Panel();
            button_View = new Button();
            button_Accounts = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(480, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1008, 972);
            dataGridView1.TabIndex = 0;
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
            panel_Left.Location = new Point(0, 1);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(432, 1039);
            panel_Left.TabIndex = 1;
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
            // button_View
            // 
            button_View.BackColor = Color.Transparent;
            button_View.Location = new Point(3, 127);
            button_View.Name = "button_View";
            button_View.Size = new Size(197, 43);
            button_View.TabIndex = 9;
            button_View.Text = "View";
            button_View.UseVisualStyleBackColor = false;
            button_View.Click += button1_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 1035);
            Controls.Add(panel_Left);
            Controls.Add(dataGridView1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_Left.ResumeLayout(false);
            panel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel_Left;
        private Label label_AccountType;
        private Label label_AccountName;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button_View;
        private Button button_Settings;
        private Button button_Accounts;
    }
}
