namespace LibraryManagement.GUI
{
    partial class OrderBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.cusId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.libId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.libName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createdDate = new System.Windows.Forms.TextBox();
            this.searchCusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // cusId
            // 
            this.cusId.Location = new System.Drawing.Point(95, 15);
            this.cusId.Name = "cusId";
            this.cusId.Size = new System.Drawing.Size(100, 20);
            this.cusId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
            // 
            // cusName
            // 
            this.cusName.Location = new System.Drawing.Point(95, 41);
            this.cusName.Name = "cusName";
            this.cusName.ReadOnly = true;
            this.cusName.Size = new System.Drawing.Size(100, 20);
            this.cusName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Librarian ID";
            // 
            // libId
            // 
            this.libId.Location = new System.Drawing.Point(95, 67);
            this.libId.Name = "libId";
            this.libId.ReadOnly = true;
            this.libId.Size = new System.Drawing.Size(100, 20);
            this.libId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Librarian Name";
            // 
            // libName
            // 
            this.libName.Location = new System.Drawing.Point(95, 93);
            this.libName.Name = "libName";
            this.libName.ReadOnly = true;
            this.libName.Size = new System.Drawing.Size(100, 20);
            this.libName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Created Date";
            // 
            // createdDate
            // 
            this.createdDate.Location = new System.Drawing.Point(95, 119);
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            this.createdDate.Size = new System.Drawing.Size(100, 20);
            this.createdDate.TabIndex = 1;
            // 
            // searchCusBtn
            // 
            this.searchCusBtn.Location = new System.Drawing.Point(201, 15);
            this.searchCusBtn.Name = "searchCusBtn";
            this.searchCusBtn.Size = new System.Drawing.Size(75, 21);
            this.searchCusBtn.TabIndex = 2;
            this.searchCusBtn.Text = "Search";
            this.searchCusBtn.UseVisualStyleBackColor = true;
            // 
            // OrderBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchCusBtn);
            this.Controls.Add(this.createdDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.libName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.libId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cusId);
            this.Controls.Add(this.label1);
            this.Name = "OrderBooks";
            this.Text = "OrderBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox libId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox libName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox createdDate;
        private System.Windows.Forms.Button searchCusBtn;
    }
}