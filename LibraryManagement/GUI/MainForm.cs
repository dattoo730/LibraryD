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
    public partial class MainForm : Form
    {
        BorrowingBooks brb;
        ReturningBook rnb;
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void borrowBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if (myUC1 != null) myUC1.Dispose();

            if (brb != null) brb.Dispose();
            brb = new BorrowingBooks();
            this.Controls.Add(brb);
           // brb.BringToFront();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rnb != null) rnb.Dispose();
            rnb = new ReturningBook();
            this.Controls.Add(rnb);
           // rnb.BringToFront();
        }
    }
}
