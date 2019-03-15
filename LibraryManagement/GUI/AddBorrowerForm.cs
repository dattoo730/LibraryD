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
        }

        public void CheckValues()
        {
            //if (BorrowerBUS.Instance.CheckNullOrEmpty(NameTextBox.Text))
            //{
            //    MessageBox.Show("BorrowerName must not be empty.", "Inform");
            //}
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //var B = new DTO.BorrowerDTO();
            //B.BorrowerID = 1;
            //B.BorrowerName =NameTextBox.Text.Trim();
            //if (MaleButton.Checked)
            //{
            //    B.BorrowerGender = "Male";
            //}
            //if(FemaleButton.Checked)
            //{
            //    B.BorrowerGender = "Female";
            //}
            //B.BorrowerBirthDate = DateTimePicker.Value;
            //B.BorrowerAddress = AddressTextBox.Text.Trim();
            //B.BorrowerPhone = PhoneTextBox.Text.Trim();
            //B.BorrowerEmail = MailTextBox.Text.Trim();

            //bool d =BorrowerBUS.Instance.AddBorrower(B);
            //if (d)
            //    MessageBox.Show("A borrower have been added.","Inform");
            //else
            //    MessageBox.Show("Can't add this borrower.", "Inform");

            CheckValues();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text.Trim()))
            {
                errorProvider.SetError(NameTextBox, "Borrower name is required.");
                // e.fo
                e.Cancel = true;

                //  borrowerIdTxt.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(NameTextBox, string.Empty);
            }
        }

        private void AddressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AddressTextBox.Text.Trim()))
            {
                errorProvider.SetError(AddressTextBox, "Borrower address is required.");
                // e.fo
                e.Cancel = true;

                //  borrowerIdTxt.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(AddressTextBox, string.Empty);
            }
        }

        private void PhoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AddressTextBox.Text.Trim()))
            {
                errorProvider.SetError(AddressTextBox, "Borrower address is required.");
                // e.fo
                e.Cancel = true;

                //  borrowerIdTxt.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(AddressTextBox, string.Empty);
            }
        }
    }
}
