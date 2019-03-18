namespace LibraryManagement.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookManagementToolStripMenuItem,
            this.borrowerManagementToolStripMenuItem,
            this.transactionManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookManagementToolStripMenuItem
            // 
            this.bookManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.searchBookToolStripMenuItem});
            this.bookManagementToolStripMenuItem.Name = "bookManagementToolStripMenuItem";
            this.bookManagementToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.bookManagementToolStripMenuItem.Text = "Book Management";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            // 
            // borrowerManagementToolStripMenuItem
            // 
            this.borrowerManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBorrowerToolStripMenuItem,
            this.searchBorrowerToolStripMenuItem});
            this.borrowerManagementToolStripMenuItem.Name = "borrowerManagementToolStripMenuItem";
            this.borrowerManagementToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.borrowerManagementToolStripMenuItem.Text = "Borrower Management";
            // 
            // addBorrowerToolStripMenuItem
            // 
            this.addBorrowerToolStripMenuItem.Name = "addBorrowerToolStripMenuItem";
            this.addBorrowerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBorrowerToolStripMenuItem.Text = "Add Borrower";
            this.addBorrowerToolStripMenuItem.Click += new System.EventHandler(this.addBorrowerToolStripMenuItem_Click);
            // 
            // searchBorrowerToolStripMenuItem
            // 
            this.searchBorrowerToolStripMenuItem.Name = "searchBorrowerToolStripMenuItem";
            this.searchBorrowerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchBorrowerToolStripMenuItem.Text = "Search Borrower";
            this.searchBorrowerToolStripMenuItem.Click += new System.EventHandler(this.searchBorrowerToolStripMenuItem_Click);
            // 
            // transactionManagementToolStripMenuItem
            // 
            this.transactionManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem});
            this.transactionManagementToolStripMenuItem.Name = "transactionManagementToolStripMenuItem";
            this.transactionManagementToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.transactionManagementToolStripMenuItem.Text = "Transaction Management";
            // 
            // borrowBooksToolStripMenuItem
            // 
            this.borrowBooksToolStripMenuItem.Name = "borrowBooksToolStripMenuItem";
            this.borrowBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrowBooksToolStripMenuItem.Text = "Borrow Books";
            this.borrowBooksToolStripMenuItem.Click += new System.EventHandler(this.borrowBooksToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(12, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(839, 509);
            this.MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 548);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBorrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBorrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
    }
}