namespace IntitialDemo
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
            button_Start = new Button();
            button_Stop = new Button();
            progressBar_StartStop = new ProgressBar();
            textBox_StartStop = new TextBox();
            checkBox_Function = new CheckBox();
            panel1 = new Panel();
            button_newForm = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_Start
            // 
            button_Start.BackColor = Color.LawnGreen;
            button_Start.Enabled = false;
            button_Start.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_Start.Location = new Point(3, 3);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(131, 57);
            button_Start.TabIndex = 0;
            button_Start.Text = "START";
            button_Start.UseVisualStyleBackColor = false;
            button_Start.Click += button_Start_Click;
            // 
            // button_Stop
            // 
            button_Stop.BackColor = Color.Pink;
            button_Stop.Enabled = false;
            button_Stop.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_Stop.Location = new Point(212, 3);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(131, 57);
            button_Stop.TabIndex = 1;
            button_Stop.Text = "STOP";
            button_Stop.UseVisualStyleBackColor = false;
            button_Stop.Click += button_Stop_Click;
            // 
            // progressBar_StartStop
            // 
            progressBar_StartStop.Location = new Point(12, 81);
            progressBar_StartStop.Name = "progressBar_StartStop";
            progressBar_StartStop.Size = new Size(1003, 29);
            progressBar_StartStop.TabIndex = 2;
            // 
            // textBox_StartStop
            // 
            textBox_StartStop.Font = new Font("Ink Free", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox_StartStop.Location = new Point(363, 306);
            textBox_StartStop.Name = "textBox_StartStop";
            textBox_StartStop.Size = new Size(265, 41);
            textBox_StartStop.TabIndex = 3;
            // 
            // checkBox_Function
            // 
            checkBox_Function.AutoSize = true;
            checkBox_Function.Location = new Point(188, 317);
            checkBox_Function.Name = "checkBox_Function";
            checkBox_Function.Size = new Size(129, 24);
            checkBox_Function.TabIndex = 4;
            checkBox_Function.Text = "Click to Enable";
            checkBox_Function.UseVisualStyleBackColor = true;
            checkBox_Function.CheckedChanged += checkBox_Function_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Start);
            panel1.Controls.Add(button_Stop);
            panel1.Location = new Point(333, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 66);
            panel1.TabIndex = 5;
            // 
            // button_newForm
            // 
            button_newForm.Location = new Point(456, 489);
            button_newForm.Name = "button_newForm";
            button_newForm.Size = new Size(94, 29);
            button_newForm.TabIndex = 6;
            button_newForm.Text = "New Form";
            button_newForm.UseVisualStyleBackColor = true;
            button_newForm.Click += button_newForm_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1027, 662);
            Controls.Add(button_newForm);
            Controls.Add(panel1);
            Controls.Add(checkBox_Function);
            Controls.Add(textBox_StartStop);
            Controls.Add(progressBar_StartStop);
            Name = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Start;
        private Button button_Stop;
        private ProgressBar progressBar_StartStop;
        private TextBox textBox_StartStop;
        private CheckBox checkBox_Function;
        private Panel panel1;
        private Button button_newForm;
    }
}
