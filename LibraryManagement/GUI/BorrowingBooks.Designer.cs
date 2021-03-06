﻿namespace LibraryManagement.GUI
{
    partial class BorrowingBooks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowingBooks));
            this.chooseBookCb = new System.Windows.Forms.ComboBox();
            this.makeOrderBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.orderCreatedDateDtp = new System.Windows.Forms.DateTimePicker();
            this.booksDgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.librarianNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.librarianIdTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityBookTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.borrowerNameTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.borrowerIdTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseBookCb
            // 
            this.chooseBookCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.chooseBookCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.chooseBookCb.FormattingEnabled = true;
            this.chooseBookCb.Location = new System.Drawing.Point(227, 64);
            this.chooseBookCb.Name = "chooseBookCb";
            this.chooseBookCb.Size = new System.Drawing.Size(162, 21);
            this.chooseBookCb.TabIndex = 48;
            this.chooseBookCb.Validating += new System.ComponentModel.CancelEventHandler(this.chooseBookCb_Validating);
            // 
            // makeOrderBtn
            // 
            this.makeOrderBtn.Location = new System.Drawing.Point(577, 351);
            this.makeOrderBtn.Name = "makeOrderBtn";
            this.makeOrderBtn.Size = new System.Drawing.Size(78, 41);
            this.makeOrderBtn.TabIndex = 47;
            this.makeOrderBtn.Text = "Borrow";
            this.makeOrderBtn.UseVisualStyleBackColor = true;
            this.makeOrderBtn.Click += new System.EventHandler(this.makeOrderBtn_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(592, 62);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(63, 23);
            this.addBookBtn.TabIndex = 46;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // orderCreatedDateDtp
            // 
            this.orderCreatedDateDtp.Enabled = false;
            this.orderCreatedDateDtp.Location = new System.Drawing.Point(231, 362);
            this.orderCreatedDateDtp.Name = "orderCreatedDateDtp";
            this.orderCreatedDateDtp.Size = new System.Drawing.Size(209, 20);
            this.orderCreatedDateDtp.TabIndex = 45;
            // 
            // booksDgv
            // 
            this.booksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDgv.Location = new System.Drawing.Point(211, 120);
            this.booksDgv.Name = "booksDgv";
            this.booksDgv.ReadOnly = true;
            this.booksDgv.Size = new System.Drawing.Size(446, 216);
            this.booksDgv.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "List of books borrowed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Date Borrowed:";
            // 
            // librarianNameTxt
            // 
            this.librarianNameTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.librarianNameTxt.Enabled = false;
            this.librarianNameTxt.Location = new System.Drawing.Point(585, 425);
            this.librarianNameTxt.Name = "librarianNameTxt";
            this.librarianNameTxt.ReadOnly = true;
            this.librarianNameTxt.Size = new System.Drawing.Size(130, 20);
            this.librarianNameTxt.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(502, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Librarian Name";
            // 
            // librarianIdTxt
            // 
            this.librarianIdTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.librarianIdTxt.Enabled = false;
            this.librarianIdTxt.Location = new System.Drawing.Point(415, 425);
            this.librarianIdTxt.Name = "librarianIdTxt";
            this.librarianIdTxt.ReadOnly = true;
            this.librarianIdTxt.Size = new System.Drawing.Size(81, 20);
            this.librarianIdTxt.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(95, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(647, 10);
            this.label10.TabIndex = 37;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(95, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(647, 10);
            this.label8.TabIndex = 28;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Borrower Name:";
            // 
            // quantityBookTxt
            // 
            this.quantityBookTxt.Location = new System.Drawing.Point(505, 64);
            this.quantityBookTxt.Name = "quantityBookTxt";
            this.quantityBookTxt.Size = new System.Drawing.Size(60, 20);
            this.quantityBookTxt.TabIndex = 39;
            this.quantityBookTxt.Validating += new System.ComponentModel.CancelEventHandler(this.quantityBookTxt_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Quantity:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // borrowerNameTxt
            // 
            this.borrowerNameTxt.Enabled = false;
            this.borrowerNameTxt.Location = new System.Drawing.Point(506, 12);
            this.borrowerNameTxt.Name = "borrowerNameTxt";
            this.borrowerNameTxt.ReadOnly = true;
            this.borrowerNameTxt.Size = new System.Drawing.Size(149, 20);
            this.borrowerNameTxt.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(95, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(647, 10);
            this.label11.TabIndex = 32;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(350, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Librarian ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Choose Book:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Search Borrower ID:";
            // 
            // borrowerIdTxt
            // 
            this.borrowerIdTxt.Location = new System.Drawing.Point(227, 12);
            this.borrowerIdTxt.Name = "borrowerIdTxt";
            this.borrowerIdTxt.Size = new System.Drawing.Size(162, 20);
            this.borrowerIdTxt.TabIndex = 40;
            this.borrowerIdTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.borrowerIdTxt_KeyUp);
            this.borrowerIdTxt.Validating += new System.ComponentModel.CancelEventHandler(this.borrowerIdTxt_Validating);
            // 
            // BorrowingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 461);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityBookTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.borrowerNameTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrowerIdTxt);
            this.MaximumSize = new System.Drawing.Size(830, 500);
            this.MinimumSize = new System.Drawing.Size(830, 500);
            this.Name = "BorrowingBooks";
            this.Text = "BorrowingBooks";
            this.Load += new System.EventHandler(this.BorrowingBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseBookCb;
        private System.Windows.Forms.Button makeOrderBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.DateTimePicker orderCreatedDateDtp;
        private System.Windows.Forms.DataGridView booksDgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox librarianNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox librarianIdTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityBookTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox borrowerNameTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox borrowerIdTxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}