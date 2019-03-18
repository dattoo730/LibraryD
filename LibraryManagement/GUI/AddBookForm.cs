using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.BUS;
using LibraryManagement.DTO;

namespace LibraryManagement.GUI
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            ShowListGridView.Hide();
            LoadCategory();
        }
        
        public void LoadCategory()
        {
            CategoryComboBox.DataSource = BooksBUS.Instance.LoadCategory();
            CategoryComboBox.DisplayMember = "Category";
            CategoryComboBox.ValueMember = "CategoryName";
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookTitleTextBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            object[] catename = new object[] { CategoryComboBox.Text };
            object[] book = new object[] { BookIDTextBox.Text, BookTitleTextBook.Text, AuthorTextBox.Text, IsbnTextBox.Text,
                  QuantityTextBox.Text, BooksBUS.Instance.GetCatogoryID(catename).ToString() };
            MessageResult message = BooksBUS.Instance.CheckDataBook(book);
            if(message.isSuccess==false)
            {
                MessageBox.Show(message.returnMessage, "Warnning");
                return;
            }
            if (BooksBUS.Instance.AddBook(book))
            {
                MessageBox.Show("Adding Book is successful", " Messages");
                BookIDTextBox.Text = "";
                BookTitleTextBook.Text = "";
                AuthorTextBox.Text = "";
                IsbnTextBox.Text = "";
                QuantityTextBox.Text = "";
                CategoryComboBox.Text = "";
            }
            else
                MessageBox.Show("Adding Book is denied", " Messages");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ShowListBookButton_Click(object sender, EventArgs e)
        {
            ShowListGridView.Show();
            ShowListGridView.DataSource = BooksBUS.Instance.LoadListBook();
        }

        private void ShowListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowListGridView.Hide();
            BookIDTextBox.Text = ShowListGridView.CurrentRow.Cells["Book ID"].Value.ToString();
            BookTitleTextBook.Text = ShowListGridView.CurrentRow.Cells["Book Title"].Value.ToString();
            AuthorTextBox.Text = ShowListGridView.CurrentRow.Cells["Author"].Value.ToString();
            IsbnTextBox.Text = ShowListGridView.CurrentRow.Cells["ISBN"].Value.ToString();
            QuantityTextBox.Text = ShowListGridView.CurrentRow.Cells["Quantity"].Value.ToString();
            CategoryComboBox.Text = ShowListGridView.CurrentRow.Cells["Category"].Value.ToString();
        }
    }
}
