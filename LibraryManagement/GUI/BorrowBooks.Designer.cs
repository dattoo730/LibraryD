namespace LibraryManagement.GUI
{
    partial class BorrowBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //public OrderBooks()
        //{
        //    cusId.Text = "dat";
        //}
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.borrowerIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowerNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.librarianIdTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.librarianNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.booksDgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.quantityBookTxt = new System.Windows.Forms.TextBox();
            this.orderCreatedDateDtp = new System.Windows.Forms.DateTimePicker();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.makeOrderBtn = new System.Windows.Forms.Button();
            this.chooseBookCb = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.booksDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Borrower ID:";
            // 
            // borrowerIdTxt
            // 
            this.borrowerIdTxt.Location = new System.Drawing.Point(119, 34);
            this.borrowerIdTxt.Name = "borrowerIdTxt";
            this.borrowerIdTxt.Size = new System.Drawing.Size(162, 20);
            this.borrowerIdTxt.TabIndex = 1;
            this.borrowerIdTxt.Validating += new System.ComponentModel.CancelEventHandler(this.borrowerIdTxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Borrower Name:";
            // 
            // borrowerNameTxt
            // 
            this.borrowerNameTxt.Location = new System.Drawing.Point(398, 34);
            this.borrowerNameTxt.Name = "borrowerNameTxt";
            this.borrowerNameTxt.ReadOnly = true;
            this.borrowerNameTxt.Size = new System.Drawing.Size(149, 20);
            this.borrowerNameTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(8, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Librarian ID";
            // 
            // librarianIdTxt
            // 
            this.librarianIdTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.librarianIdTxt.Enabled = false;
            this.librarianIdTxt.Location = new System.Drawing.Point(73, 427);
            this.librarianIdTxt.Name = "librarianIdTxt";
            this.librarianIdTxt.ReadOnly = true;
            this.librarianIdTxt.Size = new System.Drawing.Size(57, 20);
            this.librarianIdTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(337, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Librarian Name";
            // 
            // librarianNameTxt
            // 
            this.librarianNameTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.librarianNameTxt.Enabled = false;
            this.librarianNameTxt.Location = new System.Drawing.Point(420, 427);
            this.librarianNameTxt.Name = "librarianNameTxt";
            this.librarianNameTxt.ReadOnly = true;
            this.librarianNameTxt.Size = new System.Drawing.Size(130, 20);
            this.librarianNameTxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Borrowed:";
            // 
            // booksDgv
            // 
            this.booksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDgv.Location = new System.Drawing.Point(143, 126);
            this.booksDgv.Name = "booksDgv";
            this.booksDgv.Size = new System.Drawing.Size(406, 216);
            this.booksDgv.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "List of books borrowed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Choose Book:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(647, 10);
            this.label8.TabIndex = 0;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quantity:";
            // 
            // quantityBookTxt
            // 
            this.quantityBookTxt.Location = new System.Drawing.Point(397, 70);
            this.quantityBookTxt.Name = "quantityBookTxt";
            this.quantityBookTxt.Size = new System.Drawing.Size(60, 20);
            this.quantityBookTxt.TabIndex = 1;
            this.quantityBookTxt.Validating += new System.ComponentModel.CancelEventHandler(this.quantityBookTxt_Validating);
            // 
            // orderCreatedDateDtp
            // 
            this.orderCreatedDateDtp.Enabled = false;
            this.orderCreatedDateDtp.Location = new System.Drawing.Point(123, 369);
            this.orderCreatedDateDtp.Name = "orderCreatedDateDtp";
            this.orderCreatedDateDtp.Size = new System.Drawing.Size(139, 20);
            this.orderCreatedDateDtp.TabIndex = 4;
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(484, 68);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(63, 23);
            this.addBookBtn.TabIndex = 5;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // makeOrderBtn
            // 
            this.makeOrderBtn.Location = new System.Drawing.Point(473, 363);
            this.makeOrderBtn.Name = "makeOrderBtn";
            this.makeOrderBtn.Size = new System.Drawing.Size(75, 33);
            this.makeOrderBtn.TabIndex = 5;
            this.makeOrderBtn.Text = "Borrow";
            this.makeOrderBtn.UseVisualStyleBackColor = true;
            this.makeOrderBtn.Click += new System.EventHandler(this.makeOrderBtn_Click);
            // 
            // chooseBookCb
            // 
            this.chooseBookCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.chooseBookCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.chooseBookCb.FormattingEnabled = true;
            this.chooseBookCb.Location = new System.Drawing.Point(119, 70);
            this.chooseBookCb.Name = "chooseBookCb";
            this.chooseBookCb.Size = new System.Drawing.Size(162, 21);
            this.chooseBookCb.TabIndex = 6;
            this.chooseBookCb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chooseBookCb_KeyPress);
            this.chooseBookCb.Validating += new System.ComponentModel.CancelEventHandler(this.chooseBookCb_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.chooseBookCb);
            this.Controls.Add(this.makeOrderBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.orderCreatedDateDtp);
            this.Controls.Add(this.booksDgv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.librarianNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.librarianIdTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borrowerNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityBookTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.borrowerIdTxt);
            this.Controls.Add(this.label1);
            this.Name = "BorrowBooks";
            this.Text = "Borrow Books";
            ((System.ComponentModel.ISupportInitialize)(this.booksDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox borrowerIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox borrowerNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox librarianIdTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox librarianNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView booksDgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox quantityBookTxt;
        private System.Windows.Forms.DateTimePicker orderCreatedDateDtp;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button makeOrderBtn;
        private System.Windows.Forms.ComboBox chooseBookCb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}