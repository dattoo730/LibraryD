﻿using System;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryManagementEntities db = new LibraryManagementEntities();
            dataGridView1.DataSource = db.Borrowers.ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
