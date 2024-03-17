using DetailingCenterDbLib;

namespace WinFormsApp1
{
    public partial class EmployeeForm : Form
    {
        private string[] _restrictedChars = new string[] { "+", "=" };
        private readonly Repository _repository = new Repository();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            if (TryGetEmployeeFromUI(out Employee employee))
            {
                SetDefaultValues();
                _repository.SaveEmployee(employee);
                ShowEmployees();
                return;
            }
            SetError();
        }

        private void ShowEmployees()
        {
            textBoxListOfEmployees.Text = "";
            bool isSuccess = _repository.TryGetEmployees(out Employee[] employees);
            if (isSuccess)
            {
                for (int i = 0; i<employees.Length; i++)
                {
                    Employee employee = employees[i];
                    textBoxListOfEmployees.Text += $"\r\n {employee.Name} {employee.Surname} {employee.Patronymic} {employee.Phone}" +
                    $"{employee.Education} {employee.Position} {employee.Salary}";
                }
            }
        }

        private bool TryGetEmployeeFromUI(out Employee employee)
        {
            bool isNameCorrect = TryGetEmployeeName(out string firstName);
            bool isLastNameCorrect = TryGetEmployeeLastName(out string lastName);
            bool isPatronymicCorrect = TryGetEmployeePatronymic(out string patronymic);
            bool isPhoneCorrect = TryGetEmployeePhone(out string phone);
            bool isEducationCorrect = TryGetEmployeeEducation(out string education);
            bool isPositionCorrect = TryGetEmployeePosition(out string position);
            bool isSalaryCorrect = TryGetEmployeeSalary(out string salary);
            if (isNameCorrect && isLastNameCorrect && isPatronymicCorrect && isPhoneCorrect
                && isEducationCorrect && isPositionCorrect && isSalaryCorrect)
            {
                employee = new Employee()
                {
                    Name = firstName,
                    Surname = lastName,
                    Patronymic = patronymic,
                    Phone = phone,
                    Education = education,
                    Position = position,
                    Salary = salary
                };
                return true;
            }
            employee = new Employee();
            return false;
        }

        private void SetDefaultValues()
        {
            labelError.ForeColor = Color.WhiteSmoke;
            labelError.BackColor = Color.WhiteSmoke;
            textBoxEmployeeFirstName.Text = "";
            textBoxEmployeeLastName.Text = "";
            textBoxEmployeePatronymic.Text = "";
            textBoxEmployeePhone.Text = "";
            comboBoxEmployeeEducation.SelectedItem = null;
            comboBoxEmployeePosition.SelectedItem = null;
            textBoxEmployeeSalary.Text = "";
        }

        private void SetError()
        {
            labelError.BackColor = Color.Red;
            labelError.ForeColor = Color.Black;
        }

        private bool TryGetEmployeeName(out string firstName)
        {
            firstName = textBoxEmployeeFirstName.Text;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                textBoxEmployeeFirstName.BackColor = Color.Red;
                return false;
            }
            if (!firstName.All(Char.IsLetter))
            {
                textBoxEmployeeFirstName.BackColor = Color.Red;
                return false;
            }
            textBoxEmployeeFirstName.BackColor = Color.White;
            return true;
        }
        private bool TryGetEmployeeLastName(out string lastName)
        {
            lastName = textBoxEmployeeLastName.Text;
            if (string.IsNullOrWhiteSpace(lastName))
            {
                textBoxEmployeeLastName.BackColor = Color.Red;
                return false;
            }
            textBoxEmployeeLastName.BackColor = Color.White;
            return true;
        }
        private bool TryGetEmployeePatronymic(out string patronymic)
        {
            patronymic = textBoxEmployeePatronymic.Text;
            if (string.IsNullOrWhiteSpace(patronymic))
            {
                textBoxEmployeePatronymic.BackColor = Color.Red;
                return false;
            }
            textBoxEmployeePatronymic.BackColor = Color.White;
            return true;
        }
        private bool TryGetEmployeePhone(out string phone)
        {
            phone = textBoxEmployeePhone.Text;
            if (string.IsNullOrWhiteSpace(phone))
            {
                textBoxEmployeePhone.BackColor = Color.Red;
                return false;
            }
            textBoxEmployeePhone.BackColor = Color.White;
            return true;
        }
        private bool TryGetEmployeeEducation(out string education)
        {
            education = comboBoxEmployeeEducation.Text;
            if (string.IsNullOrWhiteSpace(education))
            {
                comboBoxEmployeeEducation.BackColor = Color.Red;
                return false;
            }
            comboBoxEmployeeEducation.BackColor = Color.White;
            return true;
        }
        private bool TryGetEmployeePosition(out string position)
        {
            position = comboBoxEmployeePosition.Text;
            if (string.IsNullOrWhiteSpace(position))
            {
                comboBoxEmployeePosition.BackColor = Color.Red;
                return false;
            }
            comboBoxEmployeePosition.BackColor = Color.White;
            return true;
        }
        private bool TryGetEmployeeSalary(out string salary)
        {
            salary = textBoxEmployeeSalary.Text;
            if (string.IsNullOrWhiteSpace(salary))
            {
                textBoxEmployeeSalary.BackColor = Color.Red;
                return false;
            }
            textBoxEmployeeSalary.BackColor = Color.White;
            return true;
        }

    }
}
