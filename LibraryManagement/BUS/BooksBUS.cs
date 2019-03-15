using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        private DataView dv;
        private DataTable dt = new DataTable();
        public void ShowAllBooksToCombobox(ComboBox data)
        {
            data.DataSource = BookDAO.Instance.ShowAllBooks();
            data.DisplayMember = "bookTitle";
            data.ValueMember = "bookID";
        }

        public void InitializeBookDataGridViewColumns(DataGridView data)
        {
            dt.Columns.Add(new DataColumn("BookID"));
            dt.Columns.Add(new DataColumn("BookName"));
            dt.Columns.Add(new DataColumn("Quantity"));
            dv = new DataView(dt);
            data.DataSource = dv;

        }

        public void SetDefaultValues(DateTimePicker orderCreatedDateDtp, TextBox quantityBookTxt)
        {
            orderCreatedDateDtp.Value = System.DateTime.Now;
            quantityBookTxt.Text = "1";
        }

        public void ShowCurrentSessionInfo(TextBox librarianIdTxt, TextBox librarianNameTxt)
        {
            if(!String.IsNullOrEmpty(CurrentSession.sessionId.ToString()))
            {
                librarianIdTxt.Text = CurrentSession.sessionId.ToString();
                librarianNameTxt.Text = CurrentSession.sessionName.ToString();
            }
            else
            {
                librarianIdTxt.Text = "Invalid Session!";
                librarianNameTxt.Text = "Invalid Session!";
            }           

        }

    }
}
