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
    public partial class AddBorrowerForm : Form
    {
        public AddBorrowerForm()
        {
            InitializeComponent();
            SetDayTime();
        }

        public void SetDayTime()
        {
            for(int i=1; i <= 12 ; i++)
            {
                MonthCombobox.Items.Add(i);
            }

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
