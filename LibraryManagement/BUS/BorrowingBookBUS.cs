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
    public class BorrowingBookBUS
    {
        private static BorrowingBookBUS instance;

        public static BorrowingBookBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BorrowingBookBUS();
                return instance;
            }
            private set { BorrowingBookBUS.instance = value; }
        }
        private BorrowingBookBUS() { }

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
            data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            data.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void AddBookToDataGridView(DataGridView target, ComboBox bookCb, TextBox quantityTxt)
        {
            List<string> BookIdList = new List<string>();
            bool flag = true;

            foreach (DataGridViewColumn col in target.Columns)
            {
                if (col.Name == "BookID")
                {
                    foreach (DataGridViewRow row in target.Rows)
                    {
                        var tempString = row.Cells[col.Index].Value;
                        if (tempString != null)
                            if (tempString.Equals(bookCb.SelectedValue.ToString())) flag = false;
                    }
                }
            }

            if (flag)
            {
                DataRow dr = dt.NewRow();
                dr["BookName"] = bookCb.Text;
                dr["BookID"] = bookCb.SelectedValue;
                dr["Quantity"] = quantityTxt.Text;
                dt.Rows.Add(dr);

                dv = new DataView(dt);
                target.DataSource = dv;
            }
            else MessageBox.Show("This book has already existed!");

        }

        public void SetDefaultValues(DateTimePicker orderCreatedDateDtp, TextBox quantityBookTxt)
        {
            orderCreatedDateDtp.Value = System.DateTime.Now;
            quantityBookTxt.Text = "1";
        }

        public void ShowCurrentSessionInfo(TextBox librarianIdTxt, TextBox librarianNameTxt)
        {
            if (CheckSessionIsvalid())
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

        public bool CheckSessionIsvalid()
        {
            if (!String.IsNullOrEmpty(CurrentSession.sessionId.ToString()) && CurrentSession.sessionId.ToString() != "0")
                return true;
            else
                return false;
        }

    }
}
