using System;
using System.Collections.Generic;
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
        public void ShowAllOrders(ComboBox data)
        {
            data.DataSource = OrdersDAO.Instance.ShowAllOrders();
            data.DisplayMember = "categoryName";
            data.ValueMember = "categoryID";
        }
    }
}
