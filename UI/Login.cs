﻿using DAL;
using ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            CustomerConnector cc = new CustomerConnector();
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            Customer loginCustomer = cc.Login(email, password); 
            if (loginCustomer != null)
            {
                MessageBox.Show("Login successfully");
                //FormMain.LoginNhanVien = loginemp;
                //DialogResult = DialogResult.OK;
            }
        }
    }
}
