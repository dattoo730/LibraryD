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
        public Borrower SearchBorrowerByID(TextBox borrowerIdtxt)
        {
            try
            {
                if (CheckIsNumber(borrowerIdtxt.Text) && !String.IsNullOrEmpty(borrowerIdtxt.Text))
                {
                    Borrower b = new Borrower();
                    var a = BorrowerDAO.Instance.SearchBorrowerID(Convert.ToInt32(borrowerIdtxt.Text));
                    if (a != null)
                    {
                        b.borrowerID = a.BorrowerID;
                        b.borrowerName = a.BorrowerName;
                    }
                    return b;
                }
                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
           
        }

        public void SetBorrowerNameByID(TextBox borrowerIdtxt, TextBox borrowerNameTxt)
        {
            var temp = SearchBorrowerByID(borrowerIdtxt);
            if (temp != null)
                borrowerNameTxt.Text = temp.borrowerName;
            else
                borrowerNameTxt.Text = null;
        }

        private bool CheckIsNumber(string input)
        {
            if (input.All(char.IsDigit)) return true;
            return false;
        }
        public void MakeBookBorrowingOrder(DataGridView dataDgv,
                                           TextBox borrowerIdTxt, TextBox LibrarianIdTxt)
        {
            if (CheckSessionIsvalid())
            {
                if(!String.IsNullOrEmpty(borrowerIdTxt.Text)&& !String.IsNullOrEmpty(LibrarianIdTxt.Text))
                {
                    var a = dataDgv.RowCount;
                    if (CheckIsNumber(borrowerIdTxt.Text) && CheckIsNumber(LibrarianIdTxt.Text) && dataDgv.RowCount > 1)
                    {
                        OrdersDTO ordersDto = new OrdersDTO();

                        ordersDto.BorrowerID = Convert.ToInt32(borrowerIdTxt.Text);
                        ordersDto.LibrarianID = Convert.ToInt32(LibrarianIdTxt.Text);
                        ordersDto.DateBorrowed = DateTime.Now;
                        ordersDto.ReturnDate = null;
                        ordersDto.Status = 1;//Dang muon; =2 da tra
                        
                        List<DetailOrdersDTO> detailOrdersDtoLst = new List<DetailOrdersDTO>();
                        for(int i = 0;i < dataDgv.RowCount-1;i++)
                        {
                           DetailOrdersDTO d = new DetailOrdersDTO();
                           d.BookId = Convert.ToInt32(dataDgv.Rows[i].Cells[0].Value.ToString());
                           d.QuantityBorrowed = Convert.ToInt32(dataDgv.Rows[i].Cells[2].Value.ToString());
                           detailOrdersDtoLst.Add(d);
                        }                    
                        
                        var temp = OrdersDAO.Instance.InsertNewOrder(detailOrdersDtoLst,ordersDto);
                        if (temp.isSuccess)                       
                            MessageBox.Show("Done!");
                        else
                            MessageBox.Show(temp.returnMessage);

                    }
                }
               
                   
            }
            else
                MessageBox.Show("Invalid session! Please Logout and Relogin.");
        }

        public void MakeDetailBookBorrowingOrder(DataGridView dataDgv)
        {
           
        }
    }
}
