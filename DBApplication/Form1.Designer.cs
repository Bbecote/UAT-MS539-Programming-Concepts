namespace DBApplication
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
            textBox_Age = new TextBox();
            textBox_Name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_Add = new Button();
            button_Update = new Button();
            button_Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(359, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(731, 355);
            dataGridView1.TabIndex = 0;
            // 
            // textBox_Age
            // 
            textBox_Age.Location = new Point(662, 180);
            textBox_Age.Name = "textBox_Age";
            textBox_Age.Size = new Size(100, 23);
            textBox_Age.TabIndex = 1;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(359, 180);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(265, 23);
            textBox_Name.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(662, 162);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 162);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(359, 602);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 5;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button1_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(687, 602);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(75, 23);
            button_Update.TabIndex = 6;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(1015, 602);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 7;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 995);
            Controls.Add(button_Delete);
            Controls.Add(button_Update);
            Controls.Add(button_Add);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Name);
            Controls.Add(textBox_Age);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox_Age;
        private TextBox textBox_Name;
        private Label label1;
        private Label label2;
        private Button button_Add;
        private Button button_Update;
        private Button button_Delete;
    }
}
