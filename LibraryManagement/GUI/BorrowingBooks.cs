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
    public partial class BorrowingBooks : Form
    {
        public BorrowingBooks()
        {
            InitializeComponent();
            BorrowingBookBUS.Instance.ShowAllBooksToCombobox(chooseBookCb);
            BorrowingBookBUS.Instance.InitializeBookDataGridViewColumns(booksDgv);
            BorrowingBookBUS.Instance.SetDefaultValues(orderCreatedDateDtp, quantityBookTxt);
            BorrowingBookBUS.Instance.ShowCurrentSessionInfo(librarianIdTxt, librarianNameTxt);
        }

        private void BorrowingBooks_Load(object sender, EventArgs e)
        {
            borrowerIdTxt.Focus();
        }

        private void borrowerIdTxt_KeyUp(object sender, KeyEventArgs e)
        {
            BorrowingBookBUS.Instance.SetBorrowerNameByID(borrowerIdTxt, borrowerNameTxt);
        }

        private void borrowerIdTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(borrowerIdTxt.Text.Trim()))
            {
                errorProvider1.SetError(borrowerIdTxt, "Borrower Id is required.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(borrowerIdTxt, string.Empty);
            }
        }

        private void chooseBookCb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(chooseBookCb.Text.Trim()))
            {
                errorProvider1.SetError(chooseBookCb, "That field is required.");
                e.Cancel = true;

                //  borrowerIdTxt.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(chooseBookCb, string.Empty);
            }
        }

        private void quantityBookTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(quantityBookTxt.Text.Trim()))
            {
                errorProvider1.SetError(quantityBookTxt, "Quantity is required.");
                e.Cancel = true;
                //  borrowerIdTxt.Focus();
            }
            else
            {

                if (quantityBookTxt.Text.ToString().All(char.IsDigit) == false)
                {
                    errorProvider1.SetError(quantityBookTxt, "Quantity is required a number.");
                    e.Cancel = true;
                }
                else
                {
                    if (Convert.ToInt32(quantityBookTxt.Text.ToString()) <= 0)
                    {
                        errorProvider1.SetError(quantityBookTxt, "Quantity is required a number rarther than 0.");
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(quantityBookTxt, string.Empty);
                    }

                }
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                BorrowingBookBUS.Instance.AddBookToDataGridView(booksDgv, chooseBookCb, quantityBookTxt);
            }
        }

        private void makeOrderBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                BorrowingBookBUS.Instance.MakeBookBorrowingOrder(booksDgv, borrowerIdTxt, librarianIdTxt);
            }
        }
    }
}
