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
                MessageBox.Show("A borrower have been added", "Inform");
            else
                MessageBox.Show("Can't add this borrower.", "Inform");
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
            if (string.IsNullOrEmpty(PhoneTextBox.Text.Trim()))
            {
                errorProvider.SetError(PhoneTextBox, "Borrower address is required.");
                // e.fo
                e.Cancel = true;

                //  borrowerIdTxt.Focus();
            }
            else
            {
                if (!BorrowerBUS.Instance.CheckPhoneNumber(PhoneTextBox.Text.Trim()))
                {
                    MessageBox.Show("A phone number incorrest.", "Inform");
                    errorProvider.SetError(MailTextBox, "Borrower email incorrect.");
                    //e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(MailTextBox, string.Empty);
                }

            }
        }

        private void MailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MailTextBox.Text.Trim()))
            {
                errorProvider.SetError(MailTextBox, "Borrower address is required.");
                MessageBox.Show("Textbox not empty.", "Inform");
                e.Cancel = true;

                //  borrowerIdTxt.Focus();
            }
            else
            {
                if (!BorrowerBUS.Instance.CheckEmail(MailTextBox.Text.Trim()))
                {
                    MessageBox.Show("A email incorrest.", "Inform");
                    errorProvider.SetError(MailTextBox, "Borrower email incorrect.");
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(MailTextBox, string.Empty);
                }
            }
        }
    }
}
