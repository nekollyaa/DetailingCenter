namespace WinFormsApp1
{
    partial class MainForm
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
            label1 = new Label();
            buttonServices = new Button();
            buttoProducts = new Button();
            buttoСlientele = new Button();
            buttonEmployee = new Button();
            buttonSuppliers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 54);
            label1.TabIndex = 0;
            label1.Text = "Меню";
            // 
            // buttonServices
            // 
            buttonServices.Font = new Font("Segoe UI", 18F);
            buttonServices.Location = new Point(281, 115);
            buttonServices.Name = "buttonServices";
            buttonServices.Size = new Size(245, 47);
            buttonServices.TabIndex = 1;
            buttonServices.Text = "Услуги";
            buttonServices.UseVisualStyleBackColor = true;
            buttonServices.Click += buttonServices_Click;
            // 
            // buttoProducts
            // 
            buttoProducts.Font = new Font("Segoe UI", 18F);
            buttoProducts.Location = new Point(281, 168);
            buttoProducts.Name = "buttoProducts";
            buttoProducts.Size = new Size(245, 47);
            buttoProducts.TabIndex = 2;
            buttoProducts.Text = "Товары";
            buttoProducts.UseVisualStyleBackColor = true;
            // 
            // buttoСlientele
            // 
            buttoСlientele.Font = new Font("Segoe UI", 18F);
            buttoСlientele.Location = new Point(281, 230);
            buttoСlientele.Name = "buttoСlientele";
            buttoСlientele.Size = new Size(245, 47);
            buttoСlientele.TabIndex = 3;
            buttoСlientele.Text = "Клиенты";
            buttoСlientele.UseVisualStyleBackColor = true;
            buttoСlientele.Click += buttoСlientele_Click;
            // 
            // buttonEmployee
            // 
            buttonEmployee.Font = new Font("Segoe UI", 18F);
            buttonEmployee.Location = new Point(281, 283);
            buttonEmployee.Name = "buttonEmployee";
            buttonEmployee.Size = new Size(245, 47);
            buttonEmployee.TabIndex = 4;
            buttonEmployee.Text = "Сотрудники";
            buttonEmployee.UseVisualStyleBackColor = true;
            buttonEmployee.Click += buttonEmployee_Click;
            // 
            // buttonSuppliers
            // 
            buttonSuppliers.Font = new Font("Segoe UI", 18F);
            buttonSuppliers.Location = new Point(281, 346);
            buttonSuppliers.Name = "buttonSuppliers";
            buttonSuppliers.Size = new Size(245, 47);
            buttonSuppliers.TabIndex = 5;
            buttonSuppliers.Text = "Поставщики";
            buttonSuppliers.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSuppliers);
            Controls.Add(buttonEmployee);
            Controls.Add(buttoСlientele);
            Controls.Add(buttoProducts);
            Controls.Add(buttonServices);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonServices;
        private Button buttoProducts;
        private Button buttoСlientele;
        private Button buttonEmployee;
        private Button buttonSuppliers;
    }
}