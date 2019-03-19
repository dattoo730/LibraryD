namespace LibraryManagement.GUI
{
    partial class ReturningBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturningBook));
            this.orderReturnedDateDtp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.librarianNameTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.librarianIdTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.returnNowBtn = new System.Windows.Forms.Button();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.searchOrderOptionsCb = new System.Windows.Forms.ComboBox();
            this.detailsOrderDgv = new System.Windows.Forms.DataGridView();
            this.ordersDgv = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.librarianMadeOrderTxt = new System.Windows.Forms.TextBox();
            this.selectedOrderStatusTxt = new System.Windows.Forms.TextBox();
            this.selectedOrderBorrowedDateTxt = new System.Windows.Forms.TextBox();
            this.selectedOrderNameTxt = new System.Windows.Forms.TextBox();
            this.selectedOrderIdTxt = new System.Windows.Forms.TextBox();
            this.searchOrderInputTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.detailsOrderDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // orderReturnedDateDtp
            // 
            this.orderReturnedDateDtp.Enabled = false;
            this.orderReturnedDateDtp.Location = new System.Drawing.Point(227, 381);
            this.orderReturnedDateDtp.Name = "orderReturnedDateDtp";
            this.orderReturnedDateDtp.Size = new System.Drawing.Size(119, 20);
            this.orderReturnedDateDtp.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Date Returned:";
            // 
            // librarianNameTxt
            // 
            this.librarianNameTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.librarianNameTxt.Enabled = false;
            this.librarianNameTxt.Location = new System.Drawing.Point(602, 434);
            this.librarianNameTxt.Name = "librarianNameTxt";
            this.librarianNameTxt.ReadOnly = true;
            this.librarianNameTxt.Size = new System.Drawing.Size(130, 20);
            this.librarianNameTxt.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(519, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Librarian Name";
            // 
            // librarianIdTxt
            // 
            this.librarianIdTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.librarianIdTxt.Enabled = false;
            this.librarianIdTxt.Location = new System.Drawing.Point(432, 434);
            this.librarianIdTxt.Name = "librarianIdTxt";
            this.librarianIdTxt.ReadOnly = true;
            this.librarianIdTxt.Size = new System.Drawing.Size(81, 20);
            this.librarianIdTxt.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(93, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(647, 10);
            this.label11.TabIndex = 52;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(367, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "Librarian ID";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(72, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(647, 10);
            this.label10.TabIndex = 51;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // returnNowBtn
            // 
            this.returnNowBtn.Location = new System.Drawing.Point(556, 379);
            this.returnNowBtn.Name = "returnNowBtn";
            this.returnNowBtn.Size = new System.Drawing.Size(119, 29);
            this.returnNowBtn.TabIndex = 50;
            this.returnNowBtn.Text = "Return It";
            this.returnNowBtn.UseVisualStyleBackColor = true;
            this.returnNowBtn.Click += new System.EventHandler(this.returnNowBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(131, 54);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(111, 29);
            this.showAllBtn.TabIndex = 49;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // searchOrderOptionsCb
            // 
            this.searchOrderOptionsCb.FormattingEnabled = true;
            this.searchOrderOptionsCb.Location = new System.Drawing.Point(131, 20);
            this.searchOrderOptionsCb.Name = "searchOrderOptionsCb";
            this.searchOrderOptionsCb.Size = new System.Drawing.Size(111, 21);
            this.searchOrderOptionsCb.TabIndex = 48;
            // 
            // detailsOrderDgv
            // 
            this.detailsOrderDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsOrderDgv.Location = new System.Drawing.Point(371, 245);
            this.detailsOrderDgv.Name = "detailsOrderDgv";
            this.detailsOrderDgv.Size = new System.Drawing.Size(304, 128);
            this.detailsOrderDgv.TabIndex = 46;
            // 
            // ordersDgv
            // 
            this.ordersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDgv.Location = new System.Drawing.Point(248, 54);
            this.ordersDgv.Name = "ordersDgv";
            this.ordersDgv.Size = new System.Drawing.Size(427, 133);
            this.ordersDgv.TabIndex = 47;
            this.ordersDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDgv_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Librarian:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Borrowed Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Borrower Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Borrowed Order ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Selected Borrowing Order:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Details Borrowed Order:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Search Borrowed Orders By:";
            // 
            // librarianMadeOrderTxt
            // 
            this.librarianMadeOrderTxt.Location = new System.Drawing.Point(227, 350);
            this.librarianMadeOrderTxt.Name = "librarianMadeOrderTxt";
            this.librarianMadeOrderTxt.Size = new System.Drawing.Size(119, 20);
            this.librarianMadeOrderTxt.TabIndex = 36;
            // 
            // selectedOrderStatusTxt
            // 
            this.selectedOrderStatusTxt.Location = new System.Drawing.Point(227, 324);
            this.selectedOrderStatusTxt.Name = "selectedOrderStatusTxt";
            this.selectedOrderStatusTxt.Size = new System.Drawing.Size(119, 20);
            this.selectedOrderStatusTxt.TabIndex = 35;
            // 
            // selectedOrderBorrowedDateTxt
            // 
            this.selectedOrderBorrowedDateTxt.Location = new System.Drawing.Point(227, 298);
            this.selectedOrderBorrowedDateTxt.Name = "selectedOrderBorrowedDateTxt";
            this.selectedOrderBorrowedDateTxt.Size = new System.Drawing.Size(119, 20);
            this.selectedOrderBorrowedDateTxt.TabIndex = 34;
            // 
            // selectedOrderNameTxt
            // 
            this.selectedOrderNameTxt.Location = new System.Drawing.Point(227, 272);
            this.selectedOrderNameTxt.Name = "selectedOrderNameTxt";
            this.selectedOrderNameTxt.Size = new System.Drawing.Size(119, 20);
            this.selectedOrderNameTxt.TabIndex = 33;
            // 
            // selectedOrderIdTxt
            // 
            this.selectedOrderIdTxt.Location = new System.Drawing.Point(227, 246);
            this.selectedOrderIdTxt.Name = "selectedOrderIdTxt";
            this.selectedOrderIdTxt.Size = new System.Drawing.Size(119, 20);
            this.selectedOrderIdTxt.TabIndex = 37;
            // 
            // searchOrderInputTxt
            // 
            this.searchOrderInputTxt.Location = new System.Drawing.Point(248, 20);
            this.searchOrderInputTxt.Multiline = true;
            this.searchOrderInputTxt.Name = "searchOrderInputTxt";
            this.searchOrderInputTxt.Size = new System.Drawing.Size(427, 21);
            this.searchOrderInputTxt.TabIndex = 32;
            this.searchOrderInputTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchOrderInputTxt_KeyUp);
            // 
            // ReturningBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.orderReturnedDateDtp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.librarianNameTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.librarianIdTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.returnNowBtn);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.searchOrderOptionsCb);
            this.Controls.Add(this.detailsOrderDgv);
            this.Controls.Add(this.ordersDgv);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.librarianMadeOrderTxt);
            this.Controls.Add(this.selectedOrderStatusTxt);
            this.Controls.Add(this.selectedOrderBorrowedDateTxt);
            this.Controls.Add(this.selectedOrderNameTxt);
            this.Controls.Add(this.selectedOrderIdTxt);
            this.Controls.Add(this.searchOrderInputTxt);
            this.MaximumSize = new System.Drawing.Size(830, 500);
            this.MinimumSize = new System.Drawing.Size(830, 500);
            this.Name = "ReturningBook";
            this.Text = "ReturningBook";
            ((System.ComponentModel.ISupportInitialize)(this.detailsOrderDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker orderReturnedDateDtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox librarianNameTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox librarianIdTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button returnNowBtn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.ComboBox searchOrderOptionsCb;
        private System.Windows.Forms.DataGridView detailsOrderDgv;
        private System.Windows.Forms.DataGridView ordersDgv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox librarianMadeOrderTxt;
        private System.Windows.Forms.TextBox selectedOrderStatusTxt;
        private System.Windows.Forms.TextBox selectedOrderBorrowedDateTxt;
        private System.Windows.Forms.TextBox selectedOrderNameTxt;
        private System.Windows.Forms.TextBox selectedOrderIdTxt;
        private System.Windows.Forms.TextBox searchOrderInputTxt;
    }
}