using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.DAO;
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
