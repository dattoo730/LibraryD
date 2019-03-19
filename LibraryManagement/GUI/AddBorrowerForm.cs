using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.DTO;
using LibraryManagement.BUS;

namespace LibraryManagement.GUI
{
    public partial class AddBorrowerForm : Form
    {
        
        public AddBorrowerForm()
        {
            InitializeComponent();
            SetDayTime();

        }

        public void SetDayTime()
        {
            DateTimePicker.Value = DateTime.Today;
            BorrowerIDLabel.Text = BorrowerBUS.Instance.CreateBorrowerID().ToString();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            //check empty
            if (BorrowerBUS.Instance.CheckNullOrEmpty(NameTextBox.Text.Trim()))
            {
                MessageBox.Show("User name is required.", "Inform");
                return;
            }
            else
            {
                if (!BorrowerBUS.Instance.Name(NameTextBox.Text.Trim()))
                {
                    MessageBox.Show("User name incorrest", "Inform");
                    return;
                }
            }
          
            if (BorrowerBUS.Instance.CheckNullOrEmpty(AddressTextBox.Text.Trim()))
            {
                MessageBox.Show("Addresses is required.", "Inform");
                return;
            }

            if (BorrowerBUS.Instance.CheckNullOrEmpty(PhoneTextBox.Text.Trim()))
            {
                MessageBox.Show("Phone is required.", "Inform");
                return;
            }
            else
            {
                if (!BorrowerBUS.Instance.CheckPhoneNumber(PhoneTextBox.Text.Trim()))
                {
                    MessageBox.Show("Phone number incorrest", "Inform");
                    return;
                }
            }
            if (BorrowerBUS.Instance.CheckNullOrEmpty(MailTextBox.Text.Trim()))
            {
                MessageBox.Show("Email is required.", "Inform");
                return;
            }
            else
            {
                if (!BorrowerBUS.Instance.CheckEmail(MailTextBox.Text.Trim()))
                {
                    MessageBox.Show("Email incorrest", "Inform");
                    return;
                }
            }

            var B = new DTO.BorrowerDTO();
            B.BorrowerID = BorrowerBUS.Instance.CreateBorrowerID();
            B.BorrowerName = BorrowerBUS.Instance.RemoveExtraWhitespaces(NameTextBox.Text.Trim());
            if (MaleButton.Checked)
            {
                B.BorrowerGender = "Male";
            }
            if (FemaleButton.Checked)
            {
                B.BorrowerGender = "Female";
            }
            B.BorrowerBirthDate = DateTimePicker.Value;
            B.BorrowerAddress = AddressTextBox.Text.Trim();
            B.BorrowerPhone = PhoneTextBox.Text.Trim();
            B.BorrowerEmail = MailTextBox.Text.Trim();

            bool d = BorrowerBUS.Instance.AddBorrower(B);
            if (d)
            {
                SetDayTime();
                NameTextBox.Text = "";
                AddressTextBox.Text = "";
                PhoneTextBox.Text = "";
                MailTextBox.Text = "";
                MessageBox.Show("A borrower have been added", "Inform");
            } 
            else
                MessageBox.Show("Can't add this borrower.", "Inform");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    }
}
