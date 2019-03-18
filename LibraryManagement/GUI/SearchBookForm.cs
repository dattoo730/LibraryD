using LibraryManagement.BUS;
using LibraryManagement.DTO;
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
    public partial class SearchBookForm : Form
    {
        public SearchBookForm()
        {
            InitializeComponent();
            ShowListGridView.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            object[] book = new object[] { BookTitleTextBox.Text };
            MessageResult message = BooksBUS.Instance.CheckDataSearch(book);
            if (message.isSuccess == false)
            {
                MessageBox.Show(message.returnMessage, "Warnning");
                return;
            }
            ShowListGridView.Show();
            ShowListGridView.DataSource = BooksBUS.Instance.SearchBook(book);
        }
    }
}
