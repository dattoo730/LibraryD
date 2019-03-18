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
    }
}
