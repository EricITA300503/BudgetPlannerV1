using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Policy;


namespace BudgetPlannerV1
{
    public partial class BudgetForm : Form
    {
        Form1 form1;
        public BudgetForm(Form1 frm1)
        {
            InitializeComponent();
            this.form1 = frm1;
            displayBudgetFile();

        }


        public class Budget
        {
            public string OriginalBudget
            { get; set; } = "0";

            public string CurrentBudget
            { get; set; } = "0";

            public string MoneyMade
            { get; set; }=  "0";

        }

        static string budgetFilePath = "budget.json";


        static public Budget budget = new Budget();


        void InitializeBudgetFile(string budgetFilePath)
        {
            if (!File.Exists(budgetFilePath))
            {
                // Create an empty JSON array
                File.WriteAllText(budgetFilePath, "[]"); 
            }
        }


        void displayBudgetFile()
        {
            InitializeBudgetFile(budgetFilePath);
            string budgetFile = File.ReadAllText(budgetFilePath);
            
            List<Budget> budgetList = JsonConvert.DeserializeObject<List<Budget>>(budgetFile) ?? new List<Budget>();

            if (budgetList.Count == 0) { 
                Budget temp = new Budget();
                temp.CurrentBudget = "0";
                temp.OriginalBudget = "0";
                temp.MoneyMade = "0";
                budgetList.Add(temp);
            }

            budget = budgetList[0];

            if (budgetList[0].OriginalBudget == "0")
            {
                form1.remainingBudget.Text = "0%";
            }
            else { form1.budgetPercentageText.Text = (Convert.ToDouble(budgetList[0].CurrentBudget) / Convert.ToDouble(budgetList[0].OriginalBudget) * 100).ToString("N0") + "%"; }





                Debug.Write(budgetList.Count);
            form1.moneyMadeText.Text = budgetList[0].MoneyMade;
            form1.remainingBudget.Text = budgetList[0].CurrentBudget;
            form1.budgetOutput.Text = budgetList[0].OriginalBudget;

            

        }




        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void budgetInput_TextChanged(object sender, EventArgs e)
        {

        }

        public static void updateBudgetJsonFile()
        {

            if (budget.CurrentBudget == null || budget.OriginalBudget == null)
            {
                Debug.WriteLine("Can't save if NULL");
                return;
            }

            
            
            // Create a list containing the budget object
            var budgetList = new List<Budget> { budget };

            // Serialize the list into a JSON array
            string jsonString = JsonConvert.SerializeObject(budgetList, Formatting.Indented);
            Debug.WriteLine(budgetList[0].MoneyMade);


            // Write the JSON array to the specified file
            File.WriteAllText(budgetFilePath, jsonString);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            
            InitializeBudgetFile(budgetFilePath);
            budget.OriginalBudget = budgetInput.Text;
            budget.CurrentBudget = budgetInput.Text;
            Debug.WriteLine(budget.OriginalBudget);

            form1.budgetOutput.Text = budget.OriginalBudget;
            form1.remainingBudget.Text = budget.CurrentBudget;
            
            updateBudgetJsonFile();

            form1.budgetPercentageText.Text = "100%";

            
            this.Close();

        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {

        }
    }
}
