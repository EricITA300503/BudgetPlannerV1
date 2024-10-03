using Newtonsoft.Json;
using System.Diagnostics;
using System.Windows.Forms;

namespace BudgetPlannerV1
{
    public partial class Form1 : Form
    {
        BudgetForm budgetForm;

        public Form1()
        {
            InitializeComponent();
            budgetForm = new BudgetForm(this);



        }



        private void Form1_Load(object sender, EventArgs e)
        {
            displayTransactionBoxList();
            transactionBoxList.ClearSelection();


            budgetOutput.ForeColor = Color.Black;

        }

        class Transaction
        {
            public string amountValue
            { get; set; }
            public string descriptionValue
            { get; set; }
            public string transactionDate
            { get; set; }
            public string typeOfTransaction
            { get; set; }
        }


        string transactionsFilePath = "transactions.json";



        static List<Transaction> transactions = new List<Transaction>();



        private void BudgetFormBtn_Click(object sender, EventArgs e)
        {
            budgetForm.ShowDialog();

        }

        private void transactionBoxList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the "inOut" column
            if (transactionBoxList.Columns[e.ColumnIndex].HeaderText == "In/Out")
            {

                if (e.Value != null && e.Value.ToString() == "IN")
                {
                    for (int colIndex = 0; colIndex < transactionBoxList.Columns.Count; colIndex++)
                    {
                        transactionBoxList.Rows[e.RowIndex].Cells[colIndex].Style.BackColor = Color.Green;

                    }

                }
                else if (e.Value != null && e.Value.ToString() == "OUT")
                {
                    for (int colIndex = 0; colIndex < transactionBoxList.Columns.Count; colIndex++)
                    {
                        transactionBoxList.Rows[e.RowIndex].Cells[colIndex].Style.BackColor = Color.Red;

                    }
                }
            }
        }



        void displayTransactionBoxList()
        {
            string jsonTransactions = File.ReadAllText(transactionsFilePath);
            List<Transaction> transactionsList = JsonConvert.DeserializeObject<List<Transaction>>(jsonTransactions);
            transactionsList.Reverse();
            transactionBoxList.DataSource = transactionsList;
            transactionBoxList.Columns[0].HeaderText = "Amount";
            transactionBoxList.Columns[1].HeaderText = "Description";
            transactionBoxList.Columns[2].HeaderText = "Date (yyyy-MM-dd)";
            transactionBoxList.Columns[3].HeaderText = "In/Out";

            budgetForm.budgetInput.Focus();

        }


        public static double budgetPercentage;

        private void inBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amount.Text)) { return; }

            DateTime date = DateTime.Now;

            if (File.Exists(transactionsFilePath))
            {
                var json = File.ReadAllText(transactionsFilePath);
                transactions = JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
            }
            else
            {
                transactions = new List<Transaction>();
            }


            transactions.Add(new Transaction { amountValue = amount.Text, descriptionValue = description.Text, transactionDate = date.ToString("yyyy-MM-dd"), typeOfTransaction = "IN" });
            var updatedJson = JsonConvert.SerializeObject(transactions, Formatting.Indented);



            File.WriteAllText(transactionsFilePath, updatedJson);

            double convertedMoneyMade = Convert.ToDouble(amount.Text) + Convert.ToDouble(BudgetForm.budget.MoneyMade);


            BudgetForm.budget.MoneyMade = Convert.ToString(convertedMoneyMade);
            moneyMadeText.Text = BudgetForm.budget.MoneyMade;

            BudgetForm.updateBudgetJsonFile();


            displayTransactionBoxList();
            amount.Clear();
            amount.Focus();
            description.Clear();

        }




        private void outBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amount.Text)) { return; }

            DateTime date = DateTime.Now;

            if (File.Exists(transactionsFilePath))
            {
                var json = File.ReadAllText(transactionsFilePath);
                transactions = JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
            }
            else
            {
                transactions = new List<Transaction>();
            }


            transactions.Add(new Transaction { amountValue = amount.Text, descriptionValue = description.Text, transactionDate = date.ToString("yyyy-MM-dd"), typeOfTransaction = "OUT" });
            var updatedJson = JsonConvert.SerializeObject(transactions, Formatting.Indented);



            File.WriteAllText(transactionsFilePath, updatedJson);



            double converted = Convert.ToDouble(remainingBudget.Text) - Convert.ToDouble(amount.Text);
            remainingBudget.Text = converted.ToString();


            BudgetForm.budget.CurrentBudget = remainingBudget.Text;



            budgetPercentage = (Convert.ToDouble(BudgetForm.budget.CurrentBudget) / Convert.ToDouble(BudgetForm.budget.OriginalBudget)) * 100;
            budgetPercentageText.Text = budgetPercentage.ToString("N0") + "%";
            Debug.WriteLine("BudgetPercentage is" + budgetPercentage.ToString());

            BudgetForm.updateBudgetJsonFile();

            displayTransactionBoxList();
            amount.Clear();
            amount.Focus();
            description.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void resetMoneyMadeBtn_Click(object sender, EventArgs e)
        {
            moneyMadeText.Text = "0";
            BudgetForm.budget.MoneyMade = "0";
            BudgetForm.updateBudgetJsonFile();
        }

        private void moneyMadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            { 
                e.Handled = true;
            }
        }

        
    }
}