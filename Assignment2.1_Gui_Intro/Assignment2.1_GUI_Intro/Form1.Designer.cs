namespace Assignment2._1_GUI_Intro
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
            budgetName = new TextBox();
            startBudget = new Button();
            openingCash = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            incomeName = new TextBox();
            income1stMonth = new TextBox();
            income15thMonth = new TextBox();
            expense1stMonth1 = new TextBox();
            expense1stMonth2 = new TextBox();
            expense1stMonth3 = new TextBox();
            currentBudgets = new Label();
            newBudget = new Label();
            incomeLab1 = new Label();
            expenseLabel1 = new Label();
            expenseLabel2 = new Label();
            expenseLabel3 = new Label();
            amountLabel2 = new Label();
            amountLabel1 = new Label();
            nameLabel1 = new Label();
            nameLabel2 = new Label();
            amountLabel3 = new Label();
            amountLabel4 = new Label();
            categoryLabel1 = new Label();
            expenseName1 = new TextBox();
            expenseName2 = new TextBox();
            expenseName3 = new TextBox();
            categoryName3 = new TextBox();
            categoryName2 = new TextBox();
            categoryName1 = new TextBox();
            expense15thMonth3 = new TextBox();
            expense15thMonth2 = new TextBox();
            expense15thMonth1 = new TextBox();
            SuspendLayout();
            // 
            // budgetName
            // 
            budgetName.Location = new Point(25, 138);
            budgetName.Name = "budgetName";
            budgetName.Size = new Size(155, 23);
            budgetName.TabIndex = 1;
            budgetName.Text = "Budget Name";
            budgetName.TextAlign = HorizontalAlignment.Center;
            budgetName.TextChanged += MyFirstTextbox_TextChanged;
            // 
            // startBudget
            // 
            startBudget.BackColor = SystemColors.ActiveCaption;
            startBudget.Location = new Point(331, 401);
            startBudget.Name = "startBudget";
            startBudget.Size = new Size(145, 38);
            startBudget.TabIndex = 3;
            startBudget.Text = "Start Budget";
            startBudget.UseVisualStyleBackColor = false;
            startBudget.Click += button1_Click;
            // 
            // openingCash
            // 
            openingCash.Location = new Point(186, 138);
            openingCash.Name = "openingCash";
            openingCash.Size = new Size(114, 23);
            openingCash.TabIndex = 4;
            openingCash.Text = "Opening Cash";
            openingCash.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(306, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // incomeName
            // 
            incomeName.Location = new Point(167, 208);
            incomeName.Name = "incomeName";
            incomeName.Size = new Size(146, 23);
            incomeName.TabIndex = 12;
            incomeName.TextAlign = HorizontalAlignment.Center;
            // 
            // income1stMonth
            // 
            income1stMonth.BackColor = Color.FromArgb(128, 255, 128);
            income1stMonth.Location = new Point(319, 208);
            income1stMonth.Name = "income1stMonth";
            income1stMonth.Size = new Size(131, 23);
            income1stMonth.TabIndex = 13;
            income1stMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // income15thMonth
            // 
            income15thMonth.BackColor = Color.FromArgb(128, 255, 128);
            income15thMonth.Location = new Point(456, 208);
            income15thMonth.Name = "income15thMonth";
            income15thMonth.Size = new Size(139, 23);
            income15thMonth.TabIndex = 14;
            income15thMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // expense1stMonth1
            // 
            expense1stMonth1.BackColor = Color.FromArgb(255, 192, 192);
            expense1stMonth1.Location = new Point(440, 306);
            expense1stMonth1.Name = "expense1stMonth1";
            expense1stMonth1.Size = new Size(155, 23);
            expense1stMonth1.TabIndex = 15;
            expense1stMonth1.TextAlign = HorizontalAlignment.Center;
            // 
            // expense1stMonth2
            // 
            expense1stMonth2.BackColor = Color.FromArgb(255, 192, 192);
            expense1stMonth2.Location = new Point(440, 334);
            expense1stMonth2.Name = "expense1stMonth2";
            expense1stMonth2.Size = new Size(155, 23);
            expense1stMonth2.TabIndex = 16;
            expense1stMonth2.TextAlign = HorizontalAlignment.Center;
            // 
            // expense1stMonth3
            // 
            expense1stMonth3.BackColor = Color.FromArgb(255, 192, 192);
            expense1stMonth3.Location = new Point(440, 363);
            expense1stMonth3.Name = "expense1stMonth3";
            expense1stMonth3.Size = new Size(155, 23);
            expense1stMonth3.TabIndex = 17;
            expense1stMonth3.TextAlign = HorizontalAlignment.Center;
            // 
            // currentBudgets
            // 
            currentBudgets.AutoSize = true;
            currentBudgets.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            currentBudgets.Location = new Point(320, 9);
            currentBudgets.Name = "currentBudgets";
            currentBudgets.Size = new Size(189, 28);
            currentBudgets.TabIndex = 18;
            currentBudgets.Text = "Current Budgets";
            currentBudgets.Click += label1_Click;
            // 
            // newBudget
            // 
            newBudget.AutoSize = true;
            newBudget.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            newBudget.Location = new Point(341, 91);
            newBudget.Name = "newBudget";
            newBudget.Size = new Size(141, 28);
            newBudget.TabIndex = 19;
            newBudget.Text = "New Budget";
            // 
            // incomeLab1
            // 
            incomeLab1.AutoSize = true;
            incomeLab1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            incomeLab1.Location = new Point(23, 208);
            incomeLab1.Name = "incomeLab1";
            incomeLab1.Size = new Size(113, 17);
            incomeLab1.TabIndex = 20;
            incomeLab1.Text = "Recurring Income:";
            // 
            // expenseLabel1
            // 
            expenseLabel1.AutoSize = true;
            expenseLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expenseLabel1.Location = new Point(25, 310);
            expenseLabel1.Name = "expenseLabel1";
            expenseLabel1.Size = new Size(119, 17);
            expenseLabel1.TabIndex = 21;
            expenseLabel1.Text = "Recurring Expense:";
            // 
            // expenseLabel2
            // 
            expenseLabel2.AutoSize = true;
            expenseLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expenseLabel2.Location = new Point(25, 340);
            expenseLabel2.Name = "expenseLabel2";
            expenseLabel2.Size = new Size(119, 17);
            expenseLabel2.TabIndex = 22;
            expenseLabel2.Text = "Recurring Expense:";
            // 
            // expenseLabel3
            // 
            expenseLabel3.AutoSize = true;
            expenseLabel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expenseLabel3.Location = new Point(25, 369);
            expenseLabel3.Name = "expenseLabel3";
            expenseLabel3.Size = new Size(119, 17);
            expenseLabel3.TabIndex = 23;
            expenseLabel3.Text = "Recurring Expense:";
            // 
            // amountLabel2
            // 
            amountLabel2.AutoSize = true;
            amountLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel2.Location = new Point(456, 187);
            amountLabel2.Name = "amountLabel2";
            amountLabel2.Size = new Size(139, 17);
            amountLabel2.TabIndex = 24;
            amountLabel2.Text = "Amount at 15th Month";
            // 
            // amountLabel1
            // 
            amountLabel1.AutoSize = true;
            amountLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel1.Location = new Point(319, 187);
            amountLabel1.Name = "amountLabel1";
            amountLabel1.Size = new Size(131, 17);
            amountLabel1.TabIndex = 25;
            amountLabel1.Text = "Amount at 1st Month";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel1.Location = new Point(171, 188);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new Size(142, 17);
            nameLabel1.TabIndex = 26;
            nameLabel1.Text = "Income/Expense Name";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel2.Location = new Point(171, 284);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new Size(142, 17);
            nameLabel2.TabIndex = 29;
            nameLabel2.Text = "Income/Expense Name";
            // 
            // amountLabel3
            // 
            amountLabel3.AutoSize = true;
            amountLabel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel3.Location = new Point(440, 285);
            amountLabel3.Name = "amountLabel3";
            amountLabel3.Size = new Size(131, 17);
            amountLabel3.TabIndex = 28;
            amountLabel3.Text = "Amount at 1st Month";
            // 
            // amountLabel4
            // 
            amountLabel4.AutoSize = true;
            amountLabel4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel4.Location = new Point(601, 287);
            amountLabel4.Name = "amountLabel4";
            amountLabel4.Size = new Size(139, 17);
            amountLabel4.TabIndex = 27;
            amountLabel4.Text = "Amount at 15th Month";
            amountLabel4.Click += amountLabel4_Click;
            // 
            // categoryLabel1
            // 
            categoryLabel1.AutoSize = true;
            categoryLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryLabel1.Location = new Point(321, 285);
            categoryLabel1.Name = "categoryLabel1";
            categoryLabel1.Size = new Size(113, 17);
            categoryLabel1.TabIndex = 30;
            categoryLabel1.Text = "Expense Category";
            // 
            // expenseName1
            // 
            expenseName1.Location = new Point(167, 304);
            expenseName1.Name = "expenseName1";
            expenseName1.Size = new Size(146, 23);
            expenseName1.TabIndex = 31;
            expenseName1.TextAlign = HorizontalAlignment.Center;
            // 
            // expenseName2
            // 
            expenseName2.Location = new Point(167, 333);
            expenseName2.Name = "expenseName2";
            expenseName2.Size = new Size(146, 23);
            expenseName2.TabIndex = 32;
            expenseName2.TextAlign = HorizontalAlignment.Center;
            // 
            // expenseName3
            // 
            expenseName3.Location = new Point(167, 362);
            expenseName3.Name = "expenseName3";
            expenseName3.Size = new Size(146, 23);
            expenseName3.TabIndex = 33;
            expenseName3.TextAlign = HorizontalAlignment.Center;
            // 
            // categoryName3
            // 
            categoryName3.Location = new Point(321, 363);
            categoryName3.Name = "categoryName3";
            categoryName3.Size = new Size(113, 23);
            categoryName3.TabIndex = 36;
            categoryName3.TextAlign = HorizontalAlignment.Center;
            // 
            // categoryName2
            // 
            categoryName2.Location = new Point(321, 334);
            categoryName2.Name = "categoryName2";
            categoryName2.Size = new Size(113, 23);
            categoryName2.TabIndex = 35;
            categoryName2.TextAlign = HorizontalAlignment.Center;
            // 
            // categoryName1
            // 
            categoryName1.Location = new Point(321, 305);
            categoryName1.Name = "categoryName1";
            categoryName1.Size = new Size(113, 23);
            categoryName1.TabIndex = 34;
            categoryName1.TextAlign = HorizontalAlignment.Center;
            // 
            // expense15thMonth3
            // 
            expense15thMonth3.BackColor = Color.FromArgb(255, 192, 192);
            expense15thMonth3.Location = new Point(601, 364);
            expense15thMonth3.Name = "expense15thMonth3";
            expense15thMonth3.Size = new Size(155, 23);
            expense15thMonth3.TabIndex = 39;
            expense15thMonth3.TextAlign = HorizontalAlignment.Center;
            // 
            // expense15thMonth2
            // 
            expense15thMonth2.BackColor = Color.FromArgb(255, 192, 192);
            expense15thMonth2.Location = new Point(601, 335);
            expense15thMonth2.Name = "expense15thMonth2";
            expense15thMonth2.Size = new Size(155, 23);
            expense15thMonth2.TabIndex = 38;
            expense15thMonth2.TextAlign = HorizontalAlignment.Center;
            // 
            // expense15thMonth1
            // 
            expense15thMonth1.BackColor = Color.FromArgb(255, 192, 192);
            expense15thMonth1.Location = new Point(601, 307);
            expense15thMonth1.Name = "expense15thMonth1";
            expense15thMonth1.Size = new Size(155, 23);
            expense15thMonth1.TabIndex = 37;
            expense15thMonth1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(expense15thMonth3);
            Controls.Add(expense15thMonth2);
            Controls.Add(expense15thMonth1);
            Controls.Add(categoryName3);
            Controls.Add(categoryName2);
            Controls.Add(categoryName1);
            Controls.Add(expenseName3);
            Controls.Add(expenseName2);
            Controls.Add(expenseName1);
            Controls.Add(categoryLabel1);
            Controls.Add(nameLabel2);
            Controls.Add(amountLabel3);
            Controls.Add(amountLabel4);
            Controls.Add(nameLabel1);
            Controls.Add(amountLabel1);
            Controls.Add(amountLabel2);
            Controls.Add(expenseLabel3);
            Controls.Add(expenseLabel2);
            Controls.Add(expenseLabel1);
            Controls.Add(incomeLab1);
            Controls.Add(newBudget);
            Controls.Add(currentBudgets);
            Controls.Add(expense1stMonth3);
            Controls.Add(expense1stMonth2);
            Controls.Add(expense1stMonth1);
            Controls.Add(income15thMonth);
            Controls.Add(income1stMonth);
            Controls.Add(incomeName);
            Controls.Add(dateTimePicker1);
            Controls.Add(openingCash);
            Controls.Add(startBudget);
            Controls.Add(budgetName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FirstButton;
        private TextBox budgetName;
        private Button startBudget;
        private TextBox openingCash;
        private DateTimePicker dateTimePicker1;
        private TextBox incomeName;
        private TextBox income1stMonth;
        private TextBox income15thMonth;
        private TextBox expense1stMonth1;
        private TextBox expense1stMonth2;
        private TextBox expense1stMonth3;
        private Label currentBudgets;
        private Label newBudget;
        private Label incomeLab1;
        private Label expenseLabel1;
        private Label expenseLabel2;
        private Label expenseLabel3;
        private Label amountLabel2;
        private Label amountLabel1;
        private Label nameLabel1;
        private Label nameLabel2;
        private Label amountLabel3;
        private Label amountLabel4;
        private Label categoryLabel1;
        private TextBox expenseName1;
        private TextBox expenseName2;
        private TextBox expenseName3;
        private TextBox categoryName3;
        private TextBox categoryName2;
        private TextBox categoryName1;
        private TextBox expense15thMonth3;
        private TextBox expense15thMonth2;
        private TextBox expense15thMonth1;
    }
}
