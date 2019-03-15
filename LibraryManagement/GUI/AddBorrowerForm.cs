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
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var B = new DTO.BorrowerDTO();
            B.BorrowerID = 1;
            B.BorrowerName =NameTextBox.Text;
            if (MaleButton.Checked)
            {
                B.BorrowerGender = "Male";
            }
            if(FemaleButton.Checked)
            {
                B.BorrowerGender = "Female";
            }
            B.BorrowerBirthDate = DateTimePicker.Value;
            B.BorrowerAddress = AddressTextBox.Text;
            B.BorrowerPhone = PhoneTextBox.Text;
            B.BorrowerEmail = MailTextBox.Text;

            bool d =BorrowerBUS.Instance.AddBorrower(B);
            if (d)
                MessageBox.Show("A borrower have been added.","Inform");
            else
                MessageBox.Show("Can't add this borrower.", "Inform");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
