namespace WinFormsApp1
{
    partial class Services
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
            textBoxListOfСheque = new TextBox();
            comboBoxServices = new ComboBox();
            textBoxClienteleName = new TextBox();
            textBoxClienteleDiscount = new TextBox();
            addInformationToСheque = new Button();
            textBoxEmployeeName = new TextBox();
            comboBoxServices2 = new ComboBox();
            comboBoxServices3 = new ComboBox();
            comboBoxServices4 = new ComboBox();
            comboBoxServices5 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelError = new Label();
            textBoxAmount = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22F);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(266, 41);
            label7.TabIndex = 23;
            label7.Text = "Оказанные услуги";
            // 
            // textBoxListOfСheque
            // 
            textBoxListOfСheque.Font = new Font("Segoe UI", 11F);
            textBoxListOfСheque.Location = new Point(529, 49);
            textBoxListOfСheque.Multiline = true;
            textBoxListOfСheque.Name = "textBoxListOfСheque";
            textBoxListOfСheque.Size = new Size(259, 389);
            textBoxListOfСheque.TabIndex = 39;
            // 
            // comboBoxServices
            // 
            comboBoxServices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServices.Font = new Font("Segoe UI", 11F);
            comboBoxServices.FormattingEnabled = true;
            comboBoxServices.Items.AddRange(new object[] { " ", "Химчистка салона", "Полировка кузова", "Тонировка стёкол", "Покраска кузова", "Оклейка кузова" });
            comboBoxServices.Location = new Point(265, 234);
            comboBoxServices.Name = "comboBoxServices";
            comboBoxServices.Size = new Size(242, 28);
            comboBoxServices.TabIndex = 40;
            // 
            // textBoxClienteleName
            // 
            textBoxClienteleName.Font = new Font("Segoe UI", 11F);
            textBoxClienteleName.Location = new Point(265, 135);
            textBoxClienteleName.Name = "textBoxClienteleName";
            textBoxClienteleName.Size = new Size(242, 27);
            textBoxClienteleName.TabIndex = 41;
            // 
            // textBoxClienteleDiscount
            // 
            textBoxClienteleDiscount.Font = new Font("Segoe UI", 11F);
            textBoxClienteleDiscount.Location = new Point(265, 168);
            textBoxClienteleDiscount.Name = "textBoxClienteleDiscount";
            textBoxClienteleDiscount.Size = new Size(242, 27);
            textBoxClienteleDiscount.TabIndex = 44;
            // 
            // addInformationToСheque
            // 
            addInformationToСheque.Font = new Font("Segoe UI", 11F);
            addInformationToСheque.Location = new Point(265, 398);
            addInformationToСheque.Name = "addInformationToСheque";
            addInformationToСheque.Size = new Size(242, 27);
            addInformationToСheque.TabIndex = 45;
            addInformationToСheque.Text = "Добавить данные в чек";
            addInformationToСheque.UseVisualStyleBackColor = true;
            addInformationToСheque.Click += addInformationToСheque_Click;
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.Font = new Font("Segoe UI", 11F);
            textBoxEmployeeName.Location = new Point(265, 201);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(242, 27);
            textBoxEmployeeName.TabIndex = 43;
            // 
            // comboBoxServices2
            // 
            comboBoxServices2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServices2.Font = new Font("Segoe UI", 11F);
            comboBoxServices2.FormattingEnabled = true;
            comboBoxServices2.Items.AddRange(new object[] { " ", "Химчистка салона", "Полировка кузова", "Тонировка стёкол", "Покраска кузова", "Оклейка кузова" });
            comboBoxServices2.Location = new Point(265, 258);
            comboBoxServices2.Name = "comboBoxServices2";
            comboBoxServices2.Size = new Size(242, 28);
            comboBoxServices2.TabIndex = 46;
            // 
            // comboBoxServices3
            // 
            comboBoxServices3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServices3.Font = new Font("Segoe UI", 11F);
            comboBoxServices3.FormattingEnabled = true;
            comboBoxServices3.Items.AddRange(new object[] { " ", "Химчистка салона", "Полировка кузова", "Тонировка стёкол", "Покраска кузова", "Оклейка кузова" });
            comboBoxServices3.Location = new Point(265, 282);
            comboBoxServices3.Name = "comboBoxServices3";
            comboBoxServices3.Size = new Size(242, 28);
            comboBoxServices3.TabIndex = 47;
            // 
            // comboBoxServices4
            // 
            comboBoxServices4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServices4.Font = new Font("Segoe UI", 11F);
            comboBoxServices4.FormattingEnabled = true;
            comboBoxServices4.Items.AddRange(new object[] { " ", "Химчистка салона", "Полировка кузова", "Тонировка стёкол", "Покраска кузова", "Оклейка кузова" });
            comboBoxServices4.Location = new Point(265, 307);
            comboBoxServices4.Name = "comboBoxServices4";
            comboBoxServices4.Size = new Size(242, 28);
            comboBoxServices4.TabIndex = 48;
            // 
            // comboBoxServices5
            // 
            comboBoxServices5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServices5.Font = new Font("Segoe UI", 11F);
            comboBoxServices5.FormattingEnabled = true;
            comboBoxServices5.Items.AddRange(new object[] { " ", "Химчистка салона", "Полировка кузова", "Тонировка стёкол", "Покраска кузова", "Оклейка кузова" });
            comboBoxServices5.Location = new Point(265, 331);
            comboBoxServices5.Name = "comboBoxServices5";
            comboBoxServices5.Size = new Size(242, 28);
            comboBoxServices5.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(188, 138);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 50;
            label1.Text = "Заказчик";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(202, 171);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 51;
            label2.Text = "Скидка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(158, 204);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 52;
            label3.Text = "Исполнитель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(142, 285);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 53;
            label4.Text = "Перечень услуг";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.WhiteSmoke;
            labelError.Font = new Font("Segoe UI", 9F);
            labelError.ForeColor = Color.WhiteSmoke;
            labelError.Location = new Point(309, 102);
            labelError.Name = "labelError";
            labelError.Size = new Size(146, 30);
            labelError.TabIndex = 54;
            labelError.Text = "Проверьте правильность\r\n     заполнения полей";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Font = new Font("Segoe UI", 11F);
            textBoxAmount.Location = new Point(265, 365);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(242, 27);
            textBoxAmount.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(109, 368);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 56;
            label5.Text = "Итоговая стоимость";
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBoxAmount);
            Controls.Add(labelError);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxServices5);
            Controls.Add(comboBoxServices4);
            Controls.Add(comboBoxServices3);
            Controls.Add(comboBoxServices2);
            Controls.Add(addInformationToСheque);
            Controls.Add(textBoxClienteleDiscount);
            Controls.Add(textBoxEmployeeName);
            Controls.Add(textBoxClienteleName);
            Controls.Add(comboBoxServices);
            Controls.Add(textBoxListOfСheque);
            Controls.Add(label7);
            Name = "Services";
            Text = "Services";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBoxListOfСheque;
        private ComboBox comboBoxServices;
        private TextBox textBoxClienteleName;
        private TextBox textBoxClienteleDiscount;
        private Button addInformationToСheque;
        private TextBox textBoxEmployeeName;
        private ComboBox comboBoxServices2;
        private ComboBox comboBoxServices3;
        private ComboBox comboBoxServices4;
        private ComboBox comboBoxServices5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelError;
        private TextBox textBoxAmount;
        private Label label5;
    }
}