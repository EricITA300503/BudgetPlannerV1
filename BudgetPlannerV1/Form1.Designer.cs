


using System.Windows.Forms;

namespace BudgetPlannerV1
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
            panel1 = new Panel();
            outBtn = new Button();
            inBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            description = new TextBox();
            amount = new TextBox();
            label1 = new Label();
            showBudgetPanel = new Panel();
            resetMoneyMadeBtn = new Button();
            moneyMadeLabel = new Label();
            label2 = new Label();
            moneyMadeText = new TextBox();
            budgetPercentageText = new TextBox();
            labelForCurrentBudget = new Label();
            labelForOriginalBudget = new Label();
            remainingBudget = new TextBox();
            budgetOutput = new TextBox();
            BudgetFormBtn = new Button();
            transactionBoxList = new DataGridView();
            panel1.SuspendLayout();
            showBudgetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionBoxList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(outBtn);
            panel1.Controls.Add(inBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(description);
            panel1.Controls.Add(amount);
            panel1.Location = new Point(11, 304);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 267);
            panel1.TabIndex = 0;
            // 
            // outBtn
            // 
            outBtn.BackColor = Color.Red;
            outBtn.Location = new Point(131, 209);
            outBtn.Margin = new Padding(2, 4, 2, 4);
            outBtn.Name = "outBtn";
            outBtn.Size = new Size(75, 25);
            outBtn.TabIndex = 6;
            outBtn.Text = "OUT";
            outBtn.UseVisualStyleBackColor = false;
            outBtn.Click += outBtn_Click;
            // 
            // inBtn
            // 
            inBtn.BackColor = Color.FromArgb(0, 192, 0);
            inBtn.Location = new Point(50, 209);
            inBtn.Margin = new Padding(2, 4, 2, 4);
            inBtn.Name = "inBtn";
            inBtn.Size = new Size(75, 25);
            inBtn.TabIndex = 5;
            inBtn.Text = "IN";
            inBtn.UseVisualStyleBackColor = false;
            inBtn.Click += inBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Location = new Point(26, 90);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(198, 25);
            label4.TabIndex = 4;
            label4.Text = "Description";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 15);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 2;
            label3.Text = "Enter Amount";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // description
            // 
            description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            description.BorderStyle = BorderStyle.FixedSingle;
            description.Location = new Point(26, 117);
            description.Margin = new Padding(2, 4, 2, 4);
            description.Name = "description";
            description.Size = new Size(198, 22);
            description.TabIndex = 1;
            // 
            // amount
            // 
            amount.BorderStyle = BorderStyle.FixedSingle;
            amount.Location = new Point(26, 44);
            amount.Margin = new Padding(2, 4, 2, 4);
            amount.Name = "amount";
            amount.Size = new Size(200, 22);
            amount.TabIndex = 0;
            amount.KeyPress += amount_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(204, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 16);
            label1.TabIndex = 2;
            label1.Text = "Input Form";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // showBudgetPanel
            // 
            showBudgetPanel.BackColor = Color.LightGray;
            showBudgetPanel.BorderStyle = BorderStyle.FixedSingle;
            showBudgetPanel.Controls.Add(resetMoneyMadeBtn);
            showBudgetPanel.Controls.Add(moneyMadeLabel);
            showBudgetPanel.Controls.Add(label2);
            showBudgetPanel.Controls.Add(moneyMadeText);
            showBudgetPanel.Controls.Add(budgetPercentageText);
            showBudgetPanel.Controls.Add(labelForCurrentBudget);
            showBudgetPanel.Controls.Add(labelForOriginalBudget);
            showBudgetPanel.Controls.Add(remainingBudget);
            showBudgetPanel.Controls.Add(budgetOutput);
            showBudgetPanel.Controls.Add(BudgetFormBtn);
            showBudgetPanel.Location = new Point(264, 304);
            showBudgetPanel.Margin = new Padding(2, 4, 2, 4);
            showBudgetPanel.Name = "showBudgetPanel";
            showBudgetPanel.Size = new Size(733, 192);
            showBudgetPanel.TabIndex = 5;
            // 
            // resetMoneyMadeBtn
            // 
            resetMoneyMadeBtn.Location = new Point(559, 107);
            resetMoneyMadeBtn.Margin = new Padding(2, 4, 2, 4);
            resetMoneyMadeBtn.Name = "resetMoneyMadeBtn";
            resetMoneyMadeBtn.Size = new Size(170, 25);
            resetMoneyMadeBtn.TabIndex = 11;
            resetMoneyMadeBtn.Text = "Reset Money Made";
            resetMoneyMadeBtn.UseVisualStyleBackColor = true;
            resetMoneyMadeBtn.Click += resetMoneyMadeBtn_Click;
            // 
            // moneyMadeLabel
            // 
            moneyMadeLabel.AutoSize = true;
            moneyMadeLabel.Location = new Point(21, 112);
            moneyMadeLabel.Margin = new Padding(2, 0, 2, 0);
            moneyMadeLabel.Name = "moneyMadeLabel";
            moneyMadeLabel.Size = new Size(86, 16);
            moneyMadeLabel.TabIndex = 8;
            moneyMadeLabel.Text = "Money Made:";
            moneyMadeLabel.TextAlign = ContentAlignment.MiddleCenter;
            moneyMadeLabel.Click += moneyMadeLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 16);
            label2.TabIndex = 10;
            label2.Text = "Budget Left:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // moneyMadeText
            // 
            moneyMadeText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            moneyMadeText.BackColor = SystemColors.Control;
            moneyMadeText.BorderStyle = BorderStyle.FixedSingle;
            moneyMadeText.Enabled = false;
            moneyMadeText.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moneyMadeText.Location = new Point(125, 110);
            moneyMadeText.Margin = new Padding(2, 4, 2, 4);
            moneyMadeText.Name = "moneyMadeText";
            moneyMadeText.ReadOnly = true;
            moneyMadeText.Size = new Size(333, 22);
            moneyMadeText.TabIndex = 9;
            moneyMadeText.Text = "0";
            moneyMadeText.TextAlign = HorizontalAlignment.Right;
            // 
            // budgetPercentageText
            // 
            budgetPercentageText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            budgetPercentageText.BackColor = SystemColors.Control;
            budgetPercentageText.BorderStyle = BorderStyle.FixedSingle;
            budgetPercentageText.Enabled = false;
            budgetPercentageText.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            budgetPercentageText.Location = new Point(125, 79);
            budgetPercentageText.Margin = new Padding(2, 4, 2, 4);
            budgetPercentageText.Name = "budgetPercentageText";
            budgetPercentageText.ReadOnly = true;
            budgetPercentageText.Size = new Size(333, 22);
            budgetPercentageText.TabIndex = 7;
            budgetPercentageText.TextAlign = HorizontalAlignment.Right;
            // 
            // labelForCurrentBudget
            // 
            labelForCurrentBudget.AutoSize = true;
            labelForCurrentBudget.Location = new Point(21, 50);
            labelForCurrentBudget.Margin = new Padding(2, 0, 2, 0);
            labelForCurrentBudget.Name = "labelForCurrentBudget";
            labelForCurrentBudget.Size = new Size(98, 16);
            labelForCurrentBudget.TabIndex = 6;
            labelForCurrentBudget.Text = "Current Budget:";
            labelForCurrentBudget.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelForOriginalBudget
            // 
            labelForOriginalBudget.AutoSize = true;
            labelForOriginalBudget.Location = new Point(21, 19);
            labelForOriginalBudget.Margin = new Padding(2, 0, 2, 0);
            labelForOriginalBudget.Name = "labelForOriginalBudget";
            labelForOriginalBudget.Size = new Size(100, 16);
            labelForOriginalBudget.TabIndex = 5;
            labelForOriginalBudget.Text = "Original Budget:";
            // 
            // remainingBudget
            // 
            remainingBudget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            remainingBudget.BackColor = SystemColors.Control;
            remainingBudget.BorderStyle = BorderStyle.FixedSingle;
            remainingBudget.Enabled = false;
            remainingBudget.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remainingBudget.Location = new Point(125, 48);
            remainingBudget.Margin = new Padding(2, 4, 2, 4);
            remainingBudget.Name = "remainingBudget";
            remainingBudget.ReadOnly = true;
            remainingBudget.Size = new Size(333, 22);
            remainingBudget.TabIndex = 4;
            remainingBudget.Text = "0";
            remainingBudget.TextAlign = HorizontalAlignment.Right;
            // 
            // budgetOutput
            // 
            budgetOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            budgetOutput.BorderStyle = BorderStyle.FixedSingle;
            budgetOutput.Enabled = false;
            budgetOutput.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            budgetOutput.ForeColor = Color.Black;
            budgetOutput.Location = new Point(125, 17);
            budgetOutput.Margin = new Padding(2, 4, 2, 4);
            budgetOutput.Name = "budgetOutput";
            budgetOutput.ReadOnly = true;
            budgetOutput.Size = new Size(333, 22);
            budgetOutput.TabIndex = 2;
            budgetOutput.Text = "0";
            budgetOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // BudgetFormBtn
            // 
            BudgetFormBtn.Location = new Point(559, 14);
            BudgetFormBtn.Margin = new Padding(2, 4, 2, 4);
            BudgetFormBtn.Name = "BudgetFormBtn";
            BudgetFormBtn.Size = new Size(170, 25);
            BudgetFormBtn.TabIndex = 1;
            BudgetFormBtn.Text = "Modify Monthly Budget";
            BudgetFormBtn.UseVisualStyleBackColor = true;
            BudgetFormBtn.Click += BudgetFormBtn_Click;
            // 
            // transactionBoxList
            // 
            transactionBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            transactionBoxList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionBoxList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            transactionBoxList.BackgroundColor = Color.LightGray;
            transactionBoxList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionBoxList.EditMode = DataGridViewEditMode.EditOnEnter;
            transactionBoxList.GridColor = Color.LightGray;
            transactionBoxList.Location = new Point(11, 24);
            transactionBoxList.Margin = new Padding(2, 4, 2, 4);
            transactionBoxList.Name = "transactionBoxList";
            transactionBoxList.ReadOnly = true;
            transactionBoxList.ShowEditingIcon = false;
            transactionBoxList.Size = new Size(986, 267);
            transactionBoxList.TabIndex = 6;
            transactionBoxList.CellFormatting += transactionBoxList_CellFormatting;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(1008, 598);
            Controls.Add(transactionBoxList);
            Controls.Add(showBudgetPanel);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 4, 2, 4);
            MaximumSize = new Size(1024, 637);
            MinimumSize = new Size(1024, 637);
            Name = "Form1";
            Text = "BudgetPlannerV1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            showBudgetPanel.ResumeLayout(false);
            showBudgetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionBoxList).EndInit();
            ResumeLayout(false);
        }




        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox amount;
        private TextBox description;
        private Label label3;
        private Label label4;
        private Button outBtn;
        private Button inBtn;
        private Panel showBudgetPanel;
        private Button BudgetFormBtn;
        public TextBox budgetOutput;
        public TextBox remainingBudget;
        private Label labelForCurrentBudget;
        private Label labelForOriginalBudget;
        private Label moneyMadeLabel;
        public TextBox budgetPercentageText;
        private Label label2;
        public TextBox moneyMadeText;
        private Button resetMoneyMadeBtn;
        public DataGridView transactionBoxList;
    }
}
