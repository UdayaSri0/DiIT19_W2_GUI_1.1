namespace W2_GUI_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void btnTot_Click(object sender, EventArgs e)
        {
            // Check if the Name field is empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation Error");
                return;
            }

            // Validate Number 1
            if (!double.TryParse(txtNum1.Text, out double num1))
            {
                MessageBox.Show("This Input is not compatible ", "Validation Error");
                return;
            }
            else if (txtNum1.Text.Length > 6)
            {
                MessageBox.Show("payload too large", "Validation Error");
                return;
            }

            // Validate Number 2
            if (!double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("This Input is not compatible", "Validation Error");
                return;
            }
            else if (txtNum2.Text.Length > 6)
            {
                MessageBox.Show("payload too large", "Validation Error");
                return;
            }

            // If both numbers are valid, perform the addition
            double result = num1 + num2;
            MessageBox.Show($"Hello, {txtName.Text}! The result is: {result}", "Result");
        }
    }
}
