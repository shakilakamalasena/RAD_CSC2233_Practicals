﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalAnswer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_enterData_Click(object sender, EventArgs e)
        {
            Add_Employee add_Employee = new Add_Employee();
            add_Employee.Show();
            this.Hide();
        }
    }
}
