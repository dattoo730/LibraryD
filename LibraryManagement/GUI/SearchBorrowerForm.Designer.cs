﻿namespace LibraryManagement.GUI
{
    partial class SearchBorrowerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.BorrowerDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BorrowerIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.ShowAllButton);
            this.panel1.Controls.Add(this.BorrowerDataGridView);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.BorrowerIDTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 337);
            this.panel1.TabIndex = 0;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllButton.Location = new System.Drawing.Point(679, 11);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(95, 25);
            this.ShowAllButton.TabIndex = 20;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // BorrowerDataGridView
            // 
            this.BorrowerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowerDataGridView.Location = new System.Drawing.Point(3, 51);
            this.BorrowerDataGridView.Name = "BorrowerDataGridView";
            this.BorrowerDataGridView.ReadOnly = true;
            this.BorrowerDataGridView.Size = new System.Drawing.Size(784, 283);
            this.BorrowerDataGridView.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(569, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(389, 14);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameTextBox.TabIndex = 17;
            // 
            // BorrowerIDTextBox
            // 
            this.BorrowerIDTextBox.Location = new System.Drawing.Point(115, 14);
            this.BorrowerIDTextBox.Name = "BorrowerIDTextBox";
            this.BorrowerIDTextBox.Size = new System.Drawing.Size(150, 20);
            this.BorrowerIDTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Borrower Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Borrower ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 359);
            this.Controls.Add(this.panel1);
            this.Name = "SearchBorrowerForm";
            this.Text = "SearchBorrower";
            this.Load += new System.EventHandler(this.SearchBorrowerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox BorrowerIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BorrowerDataGridView;
        private System.Windows.Forms.Button ShowAllButton;
    }
}