namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lviewExpenses.View = View.Details;
            lviewExpenses.Columns.Add("Expenses", 200);
            lviewExpenses.Columns.Add("Costs", 200);
            lviewExpenses.Columns.Add("Catergory", 200);
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {

        }
    }
}