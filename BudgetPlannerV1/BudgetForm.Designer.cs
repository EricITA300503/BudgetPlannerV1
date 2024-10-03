namespace BudgetPlannerV1
{
    partial class BudgetForm
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
            panel3 = new Panel();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            budgetInput = new TextBox();
            label5 = new Label();
            confirmButton = new Button();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox5);
            panel3.Location = new Point(343, 306);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 0);
            panel3.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(131, 196);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "OUT";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Location = new Point(50, 196);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "IN";
            button4.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.Location = new Point(25, 84);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 4;
            label6.Text = "Description";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.Location = new Point(25, 16);
            label7.Name = "label7";
            label7.Size = new Size(0, 23);
            label7.TabIndex = 2;
            label7.Text = "Enter Amount";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(25, 110);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(0, 23);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(25, 42);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(275, 91);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 6;
            label2.Text = "Budget Form";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // budgetInput
            // 
            budgetInput.Location = new Point(47, 42);
            budgetInput.Name = "budgetInput";
            budgetInput.Size = new Size(200, 23);
            budgetInput.TabIndex = 1;
            budgetInput.TextChanged += budgetInput_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Location = new Point(27, 16);
            label5.Name = "label5";
            label5.Size = new Size(234, 23);
            label5.TabIndex = 3;
            label5.Text = "Enter Amount";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(104, 71);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 6;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(confirmButton);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(budgetInput);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 261);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // BudgetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "BudgetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BudgetForm";
            Load += BudgetForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button3;
        private Button button4;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label5;
        private Button confirmButton;
        private Panel panel2;
        public TextBox budgetInput;
    }
}