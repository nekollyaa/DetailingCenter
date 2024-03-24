namespace WinFormsApp1
{
    partial class EmployeeForm
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
            addEmployee = new Button();
            textBoxEmployeeFirstName = new TextBox();
            textBoxListOfEmployees = new TextBox();
            textBoxEmployeeLastName = new TextBox();
            textBoxEmployeePatronymic = new TextBox();
            textBoxEmployeeSalary = new TextBox();
            textBoxEmployeePhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePickerEmployeeBirthDate = new DateTimePicker();
            labelError = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBoxEmployeePosition = new ComboBox();
            comboBoxEmployeeEducation = new ComboBox();
            label7 = new Label();
            deleteEmployee = new Button();
            EmployeesListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // addEmployee
            // 
            addEmployee.Font = new Font("Segoe UI", 11F);
            addEmployee.Location = new Point(136, 370);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(215, 27);
            addEmployee.TabIndex = 0;
            addEmployee.Text = "Добавить сотрудника";
            addEmployee.UseVisualStyleBackColor = true;
            addEmployee.Click += addEmployee_Click;
            // 
            // textBoxEmployeeFirstName
            // 
            textBoxEmployeeFirstName.Font = new Font("Segoe UI", 11F);
            textBoxEmployeeFirstName.Location = new Point(136, 134);
            textBoxEmployeeFirstName.Name = "textBoxEmployeeFirstName";
            textBoxEmployeeFirstName.Size = new Size(215, 27);
            textBoxEmployeeFirstName.TabIndex = 1;
            // 
            // textBoxListOfEmployees
            // 
            textBoxListOfEmployees.Font = new Font("Segoe UI", 11F);
            textBoxListOfEmployees.Location = new Point(378, 12);
            textBoxListOfEmployees.Multiline = true;
            textBoxListOfEmployees.Name = "textBoxListOfEmployees";
            textBoxListOfEmployees.Size = new Size(410, 426);
            textBoxListOfEmployees.TabIndex = 2;
            // 
            // textBoxEmployeeLastName
            // 
            textBoxEmployeeLastName.Font = new Font("Segoe UI", 11F);
            textBoxEmployeeLastName.Location = new Point(136, 163);
            textBoxEmployeeLastName.Name = "textBoxEmployeeLastName";
            textBoxEmployeeLastName.Size = new Size(215, 27);
            textBoxEmployeeLastName.TabIndex = 3;
            // 
            // textBoxEmployeePatronymic
            // 
            textBoxEmployeePatronymic.Font = new Font("Segoe UI", 11F);
            textBoxEmployeePatronymic.Location = new Point(136, 192);
            textBoxEmployeePatronymic.Name = "textBoxEmployeePatronymic";
            textBoxEmployeePatronymic.Size = new Size(215, 27);
            textBoxEmployeePatronymic.TabIndex = 4;
            // 
            // textBoxEmployeeSalary
            // 
            textBoxEmployeeSalary.Font = new Font("Segoe UI", 11F);
            textBoxEmployeeSalary.Location = new Point(136, 337);
            textBoxEmployeeSalary.Name = "textBoxEmployeeSalary";
            textBoxEmployeeSalary.Size = new Size(215, 27);
            textBoxEmployeeSalary.TabIndex = 5;
            // 
            // textBoxEmployeePhone
            // 
            textBoxEmployeePhone.Font = new Font("Segoe UI", 11F);
            textBoxEmployeePhone.Location = new Point(136, 250);
            textBoxEmployeePhone.MaxLength = 11;
            textBoxEmployeePhone.Name = "textBoxEmployeePhone";
            textBoxEmployeePhone.Size = new Size(215, 27);
            textBoxEmployeePhone.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(91, 137);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 8;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(57, 166);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 9;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(58, 195);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(57, 340);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 11;
            label4.Text = "Зарплата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(26, 282);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 12;
            label5.Text = "Образование";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(3, 253);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 13;
            label6.Text = "Номер телефона";
            // 
            // dateTimePickerEmployeeBirthDate
            // 
            dateTimePickerEmployeeBirthDate.Font = new Font("Segoe UI", 11F);
            dateTimePickerEmployeeBirthDate.Location = new Point(136, 221);
            dateTimePickerEmployeeBirthDate.Name = "dateTimePickerEmployeeBirthDate";
            dateTimePickerEmployeeBirthDate.Size = new Size(215, 27);
            dateTimePickerEmployeeBirthDate.TabIndex = 14;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.WhiteSmoke;
            labelError.Font = new Font("Segoe UI", 9F);
            labelError.ForeColor = Color.WhiteSmoke;
            labelError.Location = new Point(166, 101);
            labelError.Name = "labelError";
            labelError.Size = new Size(146, 30);
            labelError.TabIndex = 16;
            labelError.Text = "Проверьте правильность\r\n     заполнения полей";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(44, 311);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 17;
            label8.Text = "Должность";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(14, 223);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 18;
            label9.Text = "Дата рождения";
            // 
            // comboBoxEmployeePosition
            // 
            comboBoxEmployeePosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployeePosition.Font = new Font("Segoe UI", 11F);
            comboBoxEmployeePosition.FormattingEnabled = true;
            comboBoxEmployeePosition.Items.AddRange(new object[] { " ", "Администратор", "Маляр", "Детейлер", "Мойщик", "Плёнщик" });
            comboBoxEmployeePosition.Location = new Point(136, 308);
            comboBoxEmployeePosition.Name = "comboBoxEmployeePosition";
            comboBoxEmployeePosition.Size = new Size(215, 28);
            comboBoxEmployeePosition.TabIndex = 19;
            // 
            // comboBoxEmployeeEducation
            // 
            comboBoxEmployeeEducation.BackColor = SystemColors.Window;
            comboBoxEmployeeEducation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployeeEducation.Font = new Font("Segoe UI", 11F);
            comboBoxEmployeeEducation.FormattingEnabled = true;
            comboBoxEmployeeEducation.Items.AddRange(new object[] { " ", "Среднее общее", "Среднее профессиональное", "Высшее" });
            comboBoxEmployeeEducation.Location = new Point(136, 279);
            comboBoxEmployeeEducation.Name = "comboBoxEmployeeEducation";
            comboBoxEmployeeEducation.Size = new Size(215, 28);
            comboBoxEmployeeEducation.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22F);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(182, 41);
            label7.TabIndex = 21;
            label7.Text = "Сотрудники";
            // 
            // deleteEmployee
            // 
            deleteEmployee.Font = new Font("Segoe UI", 11F);
            deleteEmployee.Location = new Point(136, 403);
            deleteEmployee.Name = "deleteEmployee";
            deleteEmployee.Size = new Size(215, 27);
            deleteEmployee.TabIndex = 22;
            deleteEmployee.Text = "Удалить сотрудника";
            deleteEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeesListBox1
            // 
            EmployeesListBox1.FormattingEnabled = true;
            EmployeesListBox1.Location = new Point(794, 12);
            EmployeesListBox1.Name = "EmployeesListBox1";
            EmployeesListBox1.Size = new Size(339, 418);
            EmployeesListBox1.TabIndex = 23;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1150, 450);
            Controls.Add(EmployeesListBox1);
            Controls.Add(deleteEmployee);
            Controls.Add(label7);
            Controls.Add(comboBoxEmployeeEducation);
            Controls.Add(comboBoxEmployeePosition);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(labelError);
            Controls.Add(dateTimePickerEmployeeBirthDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEmployeePhone);
            Controls.Add(textBoxEmployeeSalary);
            Controls.Add(textBoxEmployeePatronymic);
            Controls.Add(textBoxEmployeeLastName);
            Controls.Add(textBoxListOfEmployees);
            Controls.Add(textBoxEmployeeFirstName);
            Controls.Add(addEmployee);
            Name = "EmployeeForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addEmployee;
        private TextBox textBoxEmployeeFirstName;
        private TextBox textBoxListOfEmployees;
        private TextBox textBoxEmployeeLastName;
        private TextBox textBoxEmployeePatronymic;
        private TextBox textBoxEmployeeSalary;
        private TextBox textBoxEmployeePhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerEmployeeBirthDate;
        private Label labelError;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxEmployeePosition;
        private ComboBox comboBoxEmployeeEducation;
        private Label label7;
        private Button deleteEmployee;
        private CheckedListBox EmployeesListBox1;
    }
}
