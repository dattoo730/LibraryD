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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
           
        }

        public void RemoveItem()
        {
            foreach (Control item in MainPanel.Controls.OfType<Form>())
            {
                MainPanel.Controls.Remove(item);
            }

        }
        private void borrowBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
            BorrowingBooks borrowerForm = new BorrowingBooks();
            borrowerForm.TopLevel = false;
            MainPanel.Controls.Add(borrowerForm);
            borrowerForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            borrowerForm.Dock = DockStyle.Fill;
            borrowerForm.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
            ReturningBook borrowerForm = new ReturningBook();
            borrowerForm.TopLevel = false;
            MainPanel.Controls.Add(borrowerForm);
            borrowerForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            borrowerForm.Dock = DockStyle.Fill;
            borrowerForm.Show();
        }

        private void addBorrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
            AddBorrowerForm borrowerForm = new AddBorrowerForm();
            borrowerForm.TopLevel = false;
            MainPanel.Controls.Add(borrowerForm);
            borrowerForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            borrowerForm.Dock = DockStyle.Fill;
            borrowerForm.Show();
        }

        private void searchBorrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
            SearchBorrowerForm searchBorrower = new SearchBorrowerForm();
            searchBorrower.TopLevel = false;
            MainPanel.Controls.Add(searchBorrower);
            searchBorrower.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            searchBorrower.Dock = DockStyle.Fill;
            searchBorrower.Show();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
            AddBookForm addBook = new AddBookForm();
            addBook.TopLevel = false;
            MainPanel.Controls.Add(addBook);
            addBook.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            addBook.Dock = DockStyle.Fill;
            addBook.Show();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
            SearchBookForm searchBook = new SearchBookForm();
            searchBook.TopLevel = false;
            MainPanel.Controls.Add(searchBook);
            searchBook.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            searchBook.Dock = DockStyle.Fill;
            searchBook.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RemoveItem();
            BorrowingBooks borrowerForm = new BorrowingBooks();
            borrowerForm.TopLevel = false;
            MainPanel.Controls.Add(borrowerForm);
            borrowerForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            borrowerForm.Dock = DockStyle.Fill;
            borrowerForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
