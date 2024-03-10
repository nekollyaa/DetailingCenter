namespace WinFormsApp1
{
    partial class СlienteleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            textBoxСlienteleFirstName = new TextBox();
            textBoxСlienteleLastName = new TextBox();
            dateTimePickerСlienteleBirthDate = new DateTimePicker();
            textBoxСlientelePhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label9 = new Label();
            label6 = new Label();
            comboBoxСlienteleDiscount = new ComboBox();
            label3 = new Label();
            addClientele = new Button();
            deleteEmployee = new Button();
            textBoxListOfСlientele = new TextBox();
            labelError = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22F);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(134, 41);
            label7.TabIndex = 22;
            label7.Text = "Клиенты";
            // 
            // textBoxСlienteleFirstName
            // 
            textBoxСlienteleFirstName.Font = new Font("Segoe UI", 11F);
            textBoxСlienteleFirstName.Location = new Point(134, 209);
            textBoxСlienteleFirstName.Name = "textBoxСlienteleFirstName";
            textBoxСlienteleFirstName.Size = new Size(215, 27);
            textBoxСlienteleFirstName.TabIndex = 23;
            // 
            // textBoxСlienteleLastName
            // 
            textBoxСlienteleLastName.Font = new Font("Segoe UI", 11F);
            textBoxСlienteleLastName.Location = new Point(134, 238);
            textBoxСlienteleLastName.Name = "textBoxСlienteleLastName";
            textBoxСlienteleLastName.Size = new Size(215, 27);
            textBoxСlienteleLastName.TabIndex = 24;
            // 
            // dateTimePickerСlienteleBirthDate
            // 
            dateTimePickerСlienteleBirthDate.Font = new Font("Segoe UI", 11F);
            dateTimePickerСlienteleBirthDate.Location = new Point(134, 271);
            dateTimePickerСlienteleBirthDate.Name = "dateTimePickerСlienteleBirthDate";
            dateTimePickerСlienteleBirthDate.Size = new Size(215, 27);
            dateTimePickerСlienteleBirthDate.TabIndex = 26;
            // 
            // textBoxСlientelePhone
            // 
            textBoxСlientelePhone.Font = new Font("Segoe UI", 11F);
            textBoxСlientelePhone.Location = new Point(134, 304);
            textBoxСlientelePhone.MaxLength = 11;
            textBoxСlientelePhone.Name = "textBoxСlientelePhone";
            textBoxСlientelePhone.Size = new Size(215, 27);
            textBoxСlientelePhone.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(89, 212);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 29;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(55, 245);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 30;
            label2.Text = "Фамилия";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(12, 276);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 31;
            label9.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(1, 307);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 32;
            label6.Text = "Номер телефона";
            // 
            // comboBoxСlienteleDiscount
            // 
            comboBoxСlienteleDiscount.BackColor = SystemColors.Window;
            comboBoxСlienteleDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxСlienteleDiscount.Font = new Font("Segoe UI", 11F);
            comboBoxСlienteleDiscount.FormattingEnabled = true;
            comboBoxСlienteleDiscount.Items.AddRange(new object[] { " ", "5%", "10%", "15%", "20%" });
            comboBoxСlienteleDiscount.Location = new Point(134, 337);
            comboBoxСlienteleDiscount.Name = "comboBoxСlienteleDiscount";
            comboBoxСlienteleDiscount.Size = new Size(215, 28);
            comboBoxСlienteleDiscount.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(71, 340);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 35;
            label3.Text = "Скидка";
            // 
            // addClientele
            // 
            addClientele.Font = new Font("Segoe UI", 11F);
            addClientele.Location = new Point(134, 371);
            addClientele.Name = "addClientele";
            addClientele.Size = new Size(215, 27);
            addClientele.TabIndex = 36;
            addClientele.Text = "Добавить клиента";
            addClientele.UseVisualStyleBackColor = true;
            addClientele.Click += addClientele_Click;
            // 
            // deleteEmployee
            // 
            deleteEmployee.Font = new Font("Segoe UI", 11F);
            deleteEmployee.Location = new Point(134, 404);
            deleteEmployee.Name = "deleteEmployee";
            deleteEmployee.Size = new Size(215, 27);
            deleteEmployee.TabIndex = 37;
            deleteEmployee.Text = "Изменить скидку";
            deleteEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxListOfСlientele
            // 
            textBoxListOfСlientele.Font = new Font("Segoe UI", 11F);
            textBoxListOfСlientele.Location = new Point(378, 12);
            textBoxListOfСlientele.Multiline = true;
            textBoxListOfСlientele.Name = "textBoxListOfСlientele";
            textBoxListOfСlientele.Size = new Size(410, 426);
            textBoxListOfСlientele.TabIndex = 38;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.WhiteSmoke;
            labelError.Font = new Font("Segoe UI", 9F);
            labelError.ForeColor = Color.WhiteSmoke;
            labelError.Location = new Point(167, 176);
            labelError.Name = "labelError";
            labelError.Size = new Size(146, 30);
            labelError.TabIndex = 39;
            labelError.Text = "Проверьте правильность\r\n     заполнения полей";
            // 
            // Сlientele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(labelError);
            Controls.Add(textBoxListOfСlientele);
            Controls.Add(deleteEmployee);
            Controls.Add(addClientele);
            Controls.Add(label3);
            Controls.Add(comboBoxСlienteleDiscount);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxСlientelePhone);
            Controls.Add(dateTimePickerСlienteleBirthDate);
            Controls.Add(textBoxСlienteleLastName);
            Controls.Add(textBoxСlienteleFirstName);
            Controls.Add(label7);
            Name = "Сlientele";
            Text = "Сlientele";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBoxСlienteleFirstName;
        private TextBox textBoxСlienteleLastName;
        private DateTimePicker dateTimePickerСlienteleBirthDate;
        private TextBox textBoxСlientelePhone;
        private Label label1;
        private Label label2;
        private Label label9;
        private Label label6;
        private ComboBox comboBoxСlienteleDiscount;
        private Label label3;
        private Button addClientele;
        private Button deleteEmployee;
        private TextBox textBoxListOfСlientele;
        private Label labelError;
    }
}