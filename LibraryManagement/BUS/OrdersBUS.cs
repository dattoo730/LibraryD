using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.DAO;
using LibraryManagement.DTO;

namespace LibraryManagement.BUS
{
   public class OrdersBUS
    {
        
        private static OrdersBUS instance;

        public static OrdersBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrdersBUS();
                return instance;
            }
            private set { OrdersBUS.instance = value; }
        }
        private OrdersBUS() { }


        public void ShowAllOrders(DataGridView data)
        {
            data.DataSource = OrdersDAO.Instance.ShowAllOrders();
        }

        public void ShowAllOrdersForReturning(DataGridView data)
        {
            var datas = OrdersDAO.Instance.ShowAllOrdersForReturning();
          //  data.DataSource = datas;
            DataView dv;
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("OrderID"));
            dt.Columns.Add(new DataColumn("Borrower Name"));
            dt.Columns.Add(new DataColumn("Date Borrowed"));
            dt.Columns.Add(new DataColumn("Status"));

            foreach (var i in datas)
            {
                DataRow dr = dt.NewRow();               
                dr[0] = i.OrderId;
                dr[1] = BorrowerDAO.Instance.SearchBorrowerID(i.BorrowerID).FirstOrDefault().BorrowerName;
                dr[2] = i.DateBorrowed;
                dr[3] = OrdersDAO.Instance.SearchStatusObjectByID(i.Status).FirstOrDefault().statusName;

                dt.Rows.Add(dr);
            }                    

            dv = new DataView(dt);            
            data.DataSource = dv;
            data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            data.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            data.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void SearchOrderByOption(DataGridView ordersDgv,
                                        ComboBox searchOrderOptionsCb, 
                                        TextBox searchOrderInputTxt)
        {

            ComboboxItem selectedCar = (ComboboxItem)searchOrderOptionsCb.SelectedItem;
            var option = selectedCar.Value.ToString();

            var term = searchOrderInputTxt.Text;
            var datas = OrdersDAO.Instance.SearchOrderByOption(option, term);

            DataView dv;
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("OrderID"));
            dt.Columns.Add(new DataColumn("Borrower Name"));
            dt.Columns.Add(new DataColumn("Date Borrowed"));
            dt.Columns.Add(new DataColumn("Status"));
            if(datas != null)
            {
                foreach (var i in datas)
                {
                    DataRow dr = dt.NewRow();

                    dr[0] = i.orderID;
                    dr[1] = i.borrowerName;
                    dr[2] = i.dateBorrowed;
                    dr[3] = i.statusName;

                    dt.Rows.Add(dr);
                }

            }

            dv = new DataView(dt);
            ordersDgv.DataSource = dv;
        }

        public void InitializeSearchOptions(ComboBox data)
        {
            ComboboxItem item = new ComboboxItem();
            ComboboxItem item1 = new ComboboxItem();
            ComboboxItem item2 = new ComboboxItem();
            item1.Text = "Ordered ID: ";
            item1.Value = "orderID";
            data.Items.Add(item1);

            item.Text = "Borrower ID: ";
            item.Value = "borrowerID";
            data.Items.Add(item);

            item2.Text = "Borrower name: ";
            item2.Value = "borrowerName";
            data.Items.Add(item2);
           
            data.SelectedIndex = 0;
        }

        public void SetSelectedOrderFromDgvByClick(DataGridView dgvSource, DataGridView dgvTarget,
                                                    TextBox selectedOrderIdTxt, TextBox selectedOrderNameTxt,
                                                    TextBox selectedOrderBorrowedDateTxt,
                                                    TextBox selectedOrderStatusTxt, TextBox librarianMadeOrderTxt, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string OrderId = dgvSource.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (!String.IsNullOrEmpty(OrderId) && OrderId.All(char.IsDigit))
                {
                    selectedOrderIdTxt.Text = OrderId;
                    selectedOrderNameTxt.Text = dgvSource.Rows[e.RowIndex].Cells[1].Value.ToString();
                    selectedOrderBorrowedDateTxt.Text = dgvSource.Rows[e.RowIndex].Cells[2].Value.ToString();
                    selectedOrderStatusTxt.Text = dgvSource.Rows[e.RowIndex].Cells[3].Value.ToString();
                    librarianMadeOrderTxt.Text = OrdersDAO.Instance.FindOrderByIdNotDTO(Convert.ToInt32(dgvSource.Rows[e.RowIndex].Cells[0].Value)).Librarian.librarianName;

                    var listDetailOrders = OrdersDAO.Instance.FindDetailOrderByOid(Convert.ToInt32(OrderId));
                    InitializeDetailOrders(dgvTarget, listDetailOrders);
                }
            }
           
            
        }
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        public void InitializeDetailOrders(DataGridView target, List<DetailOrder> data)
        {
            
            DataView dv;
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("BookID"));
            dt.Columns.Add(new DataColumn("BookName"));
            dt.Columns.Add(new DataColumn("Quantity"));
            
            if (data.Count > 0)
            {
                foreach (var i in data)
                {
                    DataRow dr = dt.NewRow();

                    dr[0] = i.bookID;
                    dr[1] = i.Book.bookTitle;
                    dr[2] = i.quantityBorrowed;

                    dt.Rows.Add(dr);
                }


            }

            dv = new DataView(dt);
            target.DataSource = dv;
            target.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            target.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
            target.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }


        public bool ReturnOrder(TextBox orderID, TextBox LibrarianIdTxt)
        {
            if (CheckSessionIsvalid())
            {
                if (!String.IsNullOrEmpty(LibrarianIdTxt.Text))
                {
                    
                    if (CheckIsNumber(orderID.Text))
                    {
                       bool temp = OrdersDAO.Instance.ReturnOrder(Convert.ToInt32(orderID.Text));
                        if (temp)
                        {
                            MessageBox.Show("Return Order Completed!");
                            return true;
                        }
                        
                        else {
                            MessageBox.Show("Return Order Failed!");
                            return false;
                        }
                    }
                }

                return false;
            }
            else
            {
                MessageBox.Show("Invalid session! Please Logout and Relogin.");
                return false;
               
            }
                
        }
        private bool CheckIsNumber(string input)
        {
            if (input.All(char.IsDigit)) return true;
            return false;
        }

        public bool CheckSessionIsvalid()
        {
            if (!String.IsNullOrEmpty(CurrentSession.sessionId.ToString()) && CurrentSession.sessionId.ToString() != "0")
                return true;
            else
                return false;
        }

    }
    
    

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
