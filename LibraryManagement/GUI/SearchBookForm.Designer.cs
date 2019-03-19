namespace LibraryManagement.GUI
{
    partial class SearchBookForm
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
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.BookTitleTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowListGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShowListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookTitleLabel
            // 
            this.BookTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitleLabel.Location = new System.Drawing.Point(209, 11);
            this.BookTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(109, 31);
            this.BookTitleLabel.TabIndex = 0;
            this.BookTitleLabel.Text = "Book Title";
            // 
            // BookTitleTextBox
            // 
            this.BookTitleTextBox.Location = new System.Drawing.Point(322, 11);
            this.BookTitleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookTitleTextBox.Name = "BookTitleTextBox";
            this.BookTitleTextBox.Size = new System.Drawing.Size(360, 20);
            this.BookTitleTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(696, 11);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 31);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowListGridView
            // 
            this.ShowListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowListGridView.Location = new System.Drawing.Point(25, 50);
            this.ShowListGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowListGridView.Name = "ShowListGridView";
            this.ShowListGridView.RowHeadersVisible = false;
            this.ShowListGridView.RowTemplate.Height = 24;
            this.ShowListGridView.Size = new System.Drawing.Size(778, 390);
            this.ShowListGridView.TabIndex = 3;
            // 
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 451);
            this.Controls.Add(this.ShowListGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BookTitleTextBox);
            this.Controls.Add(this.BookTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchBookForm";
            this.Text = "Search Book";
            ((System.ComponentModel.ISupportInitialize)(this.ShowListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookTitleLabel;
        private System.Windows.Forms.TextBox BookTitleTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ShowListGridView;
    }
}