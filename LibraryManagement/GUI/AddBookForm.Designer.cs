﻿namespace LibraryManagement.GUI
{
    partial class AddBookForm
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
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.IsbnLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.BookTitleTextBook = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ShowListBookButton = new System.Windows.Forms.Button();
            this.ShowListGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShowListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDLabel.Location = new System.Drawing.Point(12, 27);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(159, 42);
            this.BookIDLabel.TabIndex = 0;
            this.BookIDLabel.Text = "Book ID:";
            this.BookIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(12, 324);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(159, 42);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "Quantity:";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IsbnLabel
            // 
            this.IsbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsbnLabel.Location = new System.Drawing.Point(12, 264);
            this.IsbnLabel.Name = "IsbnLabel";
            this.IsbnLabel.Size = new System.Drawing.Size(159, 42);
            this.IsbnLabel.TabIndex = 2;
            this.IsbnLabel.Text = "ISBN:";
            this.IsbnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(12, 204);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(159, 42);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category:";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(12, 148);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(159, 42);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author:";
            this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookTitleLabel
            // 
            this.BookTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitleLabel.Location = new System.Drawing.Point(12, 89);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(159, 42);
            this.BookTitleLabel.TabIndex = 5;
            this.BookTitleLabel.Text = "Book Title:";
            this.BookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.Location = new System.Drawing.Point(192, 39);
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(260, 22);
            this.BookIDTextBox.TabIndex = 6;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(192, 160);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(260, 22);
            this.AuthorTextBox.TabIndex = 8;
            // 
            // BookTitleTextBook
            // 
            this.BookTitleTextBook.Location = new System.Drawing.Point(192, 101);
            this.BookTitleTextBook.Name = "BookTitleTextBook";
            this.BookTitleTextBook.Size = new System.Drawing.Size(260, 22);
            this.BookTitleTextBook.TabIndex = 9;
            this.BookTitleTextBook.TextChanged += new System.EventHandler(this.BookTitleTextBook_TextChanged);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(192, 336);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(260, 22);
            this.QuantityTextBox.TabIndex = 7;
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(192, 276);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(260, 22);
            this.IsbnTextBox.TabIndex = 9;
            this.IsbnTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(193, 216);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(259, 24);
            this.CategoryComboBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(403, 404);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(131, 35);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(569, 404);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(131, 35);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ShowListBookButton
            // 
            this.ShowListBookButton.Location = new System.Drawing.Point(458, 38);
            this.ShowListBookButton.Name = "ShowListBookButton";
            this.ShowListBookButton.Size = new System.Drawing.Size(31, 25);
            this.ShowListBookButton.TabIndex = 13;
            this.ShowListBookButton.Text = "...";
            this.ShowListBookButton.UseVisualStyleBackColor = true;
            this.ShowListBookButton.Click += new System.EventHandler(this.ShowListBookButton_Click);
            // 
            // ShowListGridView
            // 
            this.ShowListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowListGridView.Location = new System.Drawing.Point(2, 2);
            this.ShowListGridView.Name = "ShowListGridView";
            this.ShowListGridView.RowHeadersVisible = false;
            this.ShowListGridView.RowTemplate.Height = 24;
            this.ShowListGridView.Size = new System.Drawing.Size(796, 448);
            this.ShowListGridView.TabIndex = 14;
            this.ShowListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowListGridView_CellContentClick);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowListGridView);
            this.Controls.Add(this.ShowListBookButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.BookTitleTextBook);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.BookIDTextBox);
            this.Controls.Add(this.BookTitleLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.IsbnLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.BookIDLabel);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.ShowListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label IsbnLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label BookTitleLabel;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox BookTitleTextBook;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ShowListBookButton;
        private System.Windows.Forms.DataGridView ShowListGridView;
    }
}