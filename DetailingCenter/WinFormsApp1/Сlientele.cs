namespace WinFormsApp1
{
    public partial class Сlientele : Form
    {
        public Сlientele()
        {
            InitializeComponent();
        }

        private void addClientele_Click(object sender, EventArgs e)
        {
            bool isNameCorrect = TryGetСlienteleName(out string firstName);
            bool isLastNameCorrect = TryGetСlienteleLastName(out string lastName);
            bool isPhoneCorrect = TryGetСlientelePhone(out string phone);
            bool isDiscountCorrect = TryGetСlienteleDiscount(out string discount);
            if (isNameCorrect && isLastNameCorrect && isPhoneCorrect && isDiscountCorrect)
            {
                textBoxListOfСlientele.Text += $"\r\n {firstName} {lastName} {phone} {discount}";
                labelError.ForeColor = Color.WhiteSmoke;
                labelError.BackColor = Color.WhiteSmoke;
                textBoxСlienteleFirstName.Text = "";
                textBoxСlienteleLastName.Text = "";
                textBoxСlientelePhone.Text = "";
                comboBoxСlienteleDiscount.Text = "";
                return;
            }
            labelError.BackColor = Color.Red;
            labelError.ForeColor = Color.Black;
        }
        private bool TryGetСlienteleName(out string firstName)
        {
            firstName = textBoxСlienteleFirstName.Text;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                textBoxСlienteleFirstName.BackColor = Color.Red;
                return false;
            }
            if (!firstName.All(Char.IsLetter))
            {
                textBoxСlienteleFirstName.BackColor = Color.Red;
                return false;
            }
            textBoxСlienteleFirstName.BackColor = Color.White;
            return true;
        }
        private bool TryGetСlienteleLastName(out string lastName)
        {
            lastName = textBoxСlienteleLastName.Text;
            if (string.IsNullOrWhiteSpace(lastName))
            {
                textBoxСlienteleLastName.BackColor = Color.Red;
                return false;
            }
            textBoxСlienteleLastName.BackColor = Color.White;
            return true;
        }
        private bool TryGetСlientelePhone(out string phone)
        {
            phone = textBoxСlientelePhone.Text;
            if (string.IsNullOrWhiteSpace(phone))
            {
                textBoxСlientelePhone.BackColor = Color.Red;
                return false;
            }
            textBoxСlientelePhone.BackColor = Color.White;
            return true;
        }
        private bool TryGetСlienteleDiscount(out string discount)
        {
            discount = comboBoxСlienteleDiscount.Text;
            if (string.IsNullOrWhiteSpace(discount))
            {
                comboBoxСlienteleDiscount.BackColor = Color.Red;
                return false;
            }
            comboBoxСlienteleDiscount.BackColor = Color.White;
            return true;
        }
    }
}
