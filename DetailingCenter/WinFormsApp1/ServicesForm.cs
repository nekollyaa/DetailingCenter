namespace WinFormsApp1
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void addInformationToСheque_Click(object sender, EventArgs e)
        {
            bool isClienteleNameCorrect = TryGetСlienteleName(out string clientName);
            bool isClienteleDiscountCorrect = TryGetClienteleDiscount(out string discount);
            bool isEmployeeNameCorrect = TryGetEmployeeName(out string employeeName);
            bool isAmountCorrect = TryGetEmployeeName(out string amount);
            if (isClienteleNameCorrect && isClienteleDiscountCorrect && isEmployeeNameCorrect
                && isAmountCorrect)
            {
                textBoxListOfСheque.Text += $"\r\n {clientName} {discount} \r\n{employeeName}" +
                    $"\r\n {amount}";
                labelError.ForeColor = Color.WhiteSmoke;
                labelError.BackColor = Color.WhiteSmoke;
                textBoxClienteleName.Text = "";
                textBoxClienteleDiscount.Text = "";
                textBoxEmployeeName.Text = "";
                return;
            }
            labelError.BackColor = Color.Red;
            labelError.ForeColor = Color.Black;
        }
        private bool TryGetСlienteleName(out string clientName)
        {
            clientName = textBoxClienteleName.Text;
            if (string.IsNullOrWhiteSpace(clientName))
            {
                textBoxClienteleName.BackColor = Color.Red;
                return false;
            }
            if (!clientName.All(Char.IsLetter))
            {
                textBoxClienteleName.BackColor = Color.Red;
                return false;
            }
            textBoxClienteleName.BackColor = Color.White;
            return true;
        }
        private bool TryGetClienteleDiscount(out string discount)
        {
            discount = textBoxClienteleDiscount.Text;
            if (string.IsNullOrWhiteSpace(discount))
            {
                textBoxClienteleDiscount.BackColor = Color.Red;
                return false;
            }
            textBoxClienteleDiscount.BackColor = Color.White;
            return true;
        }
        private bool TryGetEmployeeName(out string employeeName)
        {
            employeeName = textBoxEmployeeName.Text;
            if (string.IsNullOrWhiteSpace(employeeName))
            {
                textBoxEmployeeName.BackColor = Color.Red;
                return false;
            }
            textBoxEmployeeName.BackColor = Color.White;
            return true;
        }
        private bool TryGetAmount(out string amount)
        {
            amount = textBoxAmount.Text;
            if (string.IsNullOrWhiteSpace(amount))
            {
                textBoxAmount.BackColor = Color.Red;
                return false;
            }
            textBoxAmount.BackColor = Color.White;
            return true;
        }
    }
}
