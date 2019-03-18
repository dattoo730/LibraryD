using LibraryManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class LoginLibrarian : Form
    {
        public LoginLibrarian()
        {
            InitializeComponent();
        }

        MainForm mn;
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if(!String.IsNullOrEmpty(userId.Text)&& !String.IsNullOrEmpty(userPass.Text))
            {
                if (!LoginLibrarianBUS.Instance.CheckNumber(userId.Text))
                {
                    lblCorrect.Text = " User name must be number.";
                    return;
                }
                    
                var a =  LoginLibrarianBUS.Instance.checkLogin(Convert.ToInt32(userId.Text), userPass.Text);
                if(a==true)
                {
                    this.Hide();
                    mn = new MainForm();// chuyen trang chinh
                    mn.Show();
                }
                else //nhap lai
                {
                    lblCorrect.Text = " user or passwod is not corret ";
                    userId.Text = "";
                    userPass.Text = "";
                    lblUser.Focus();
                }
            }
            else
            {
                lblCorrect.Text = "User name or password not empty.";
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if(checkShowPassword.Checked)
            {
                userPass.UseSystemPasswordChar = false;
            }
            else
            {
                userPass.UseSystemPasswordChar = true ;
            }

        }

        private void userPass_TextChanged(object sender, EventArgs e)
        {
            userPass.UseSystemPasswordChar = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            userId.Text = "";
            userPass.Text = "";
            lblUser.Focus();
        }
    }
}
