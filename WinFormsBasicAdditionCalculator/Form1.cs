namespace WinFormsBasicAdditionCalculator
{
    public partial class FormBasicAdditionCalculator : Form
    {
        public FormBasicAdditionCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(txtNumber1.Text) + int.Parse(txtNumber2.Text);
            txtResult.Text = $"Sum: {sum}";
        }
    }
}
