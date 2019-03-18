using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.BUS;

namespace LibraryManagement.GUI
{
    public partial class ReturningBook : UserControl
    {
        public ReturningBook()
        {
            InitializeComponent();
            orderReturnedDateDtp.Value = DateTime.Now;
            OrdersBUS.Instance.InitializeSearchOptions(searchOrderOptionsCb);
            BorrowingBookBUS.Instance.ShowCurrentSessionInfo(librarianIdTxt, librarianNameTxt);
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            OrdersBUS.Instance.ShowAllOrdersForReturning(ordersDgv);
        }

        private void searchOrderInputTxt_KeyUp(object sender, KeyEventArgs e)
        {
            OrdersBUS.Instance.SearchOrderByOption(ordersDgv, searchOrderOptionsCb, searchOrderInputTxt);
        }

        private void ordersDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(e.RowIndex.ToString());
            OrdersBUS.Instance.SetSelectedOrderFromDgvByClick(ordersDgv, detailsOrderDgv, selectedOrderIdTxt, selectedOrderNameTxt, selectedOrderBorrowedDateTxt, selectedOrderStatusTxt, librarianMadeOrderTxt, e);
        }

        private void returnNowBtn_Click(object sender, EventArgs e)
        {
           bool temp = OrdersBUS.Instance.ReturnOrder(selectedOrderIdTxt, librarianIdTxt);
           if(temp)
            {
                OrdersBUS.Instance.ShowAllOrdersForReturning(ordersDgv);
                searchOrderInputTxt.ResetText();
                selectedOrderIdTxt.ResetText();

                selectedOrderNameTxt.ResetText();
                selectedOrderBorrowedDateTxt.ResetText();
                selectedOrderStatusTxt.ResetText();
                librarianMadeOrderTxt.ResetText();
                
                detailsOrderDgv.DataSource = null;

            }
        }
    }
}
