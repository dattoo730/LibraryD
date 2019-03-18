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
            this.BookTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitleLabel.Location = new System.Drawing.Point(21, 20);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(145, 38);
            this.BookTitleLabel.TabIndex = 0;
            this.BookTitleLabel.Text = "Book Title";
            // 
            // BookTitleTextBox
            // 
            this.BookTitleTextBox.Location = new System.Drawing.Point(148, 22);
            this.BookTitleTextBox.Name = "BookTitleTextBox";
            this.BookTitleTextBox.Size = new System.Drawing.Size(391, 22);
            this.BookTitleTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(625, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(143, 38);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowListGridView
            // 
            this.ShowListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowListGridView.Location = new System.Drawing.Point(-2, 61);
            this.ShowListGridView.Name = "ShowListGridView";
            this.ShowListGridView.RowHeadersVisible = false;
            this.ShowListGridView.RowTemplate.Height = 24;
            this.ShowListGridView.Size = new System.Drawing.Size(800, 388);
            this.ShowListGridView.TabIndex = 3;
            // 
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowListGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BookTitleTextBox);
            this.Controls.Add(this.BookTitleLabel);
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