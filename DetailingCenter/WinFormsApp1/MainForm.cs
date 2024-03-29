﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            ServicesForm service = new ServicesForm();
            service.Show();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
        }

        private void buttoСlientele_Click(object sender, EventArgs e)
        {
            СlienteleForm clientele = new СlienteleForm();
            clientele.Show();
        }
    }
}
