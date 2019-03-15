using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.BUS
{
   public class BooksBUS
    {
        private static BooksBUS instance;

        public static BooksBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BooksBUS();
                return instance;
            }
            private set { BooksBUS.instance = value; }
        }
        private BooksBUS() { }

        public void ShowAllBooks(ComboBox data)
        {
            data.DataSource = BookDAO.Instance.ShowAllBooks();
            data.DisplayMember = "bookTitle";
            data.ValueMember = "bookID";
        }
        public void ShowAllBookstne(ComboBox data)
        {
            data.DataSource = BookDAO.Instance.ShowAllBooks();
            data.DisplayMember = "bookTitle";
            data.ValueMember = "bookID";
        }
        public void gfggg(ComboBox data)
        {
            data.DataSource = BookDAO.Instance.ShowAllBooks();
            data.DisplayMember = "bookTitle";
            data.ValueMember = "bookID";
        }
    }
}
