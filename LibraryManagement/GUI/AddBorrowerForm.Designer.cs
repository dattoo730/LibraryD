namespace LibraryManagement.GUI
{
    partial class AddBorrowerForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.BorrowerIDLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MonthCombobox = new System.Windows.Forms.ComboBox();
            this.DayCombobox = new System.Windows.Forms.ComboBox();
            this.YearCombobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.YearCombobox);
            this.panel1.Controls.Add(this.DayCombobox);
            this.panel1.Controls.Add(this.MonthCombobox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.FemaleButton);
            this.panel1.Controls.Add(this.MaleButton);
            this.panel1.Controls.Add(this.BorrowerIDLabel);
            this.panel1.Controls.Add(this.PhoneTextBox);
            this.panel1.Controls.Add(this.AddressTextBox);
            this.panel1.Controls.Add(this.MailTextBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 337);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(280, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "/";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(355, 285);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(104, 23);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(499, 285);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 23);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // FemaleButton
            // 
            this.FemaleButton.Location = new System.Drawing.Point(234, 173);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(69, 20);
            this.FemaleButton.TabIndex = 17;
            this.FemaleButton.TabStop = true;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            // 
            // MaleButton
            // 
            this.MaleButton.Location = new System.Drawing.Point(158, 173);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(70, 20);
            this.MaleButton.TabIndex = 16;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            // 
            // BorrowerIDLabel
            // 
            this.BorrowerIDLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorrowerIDLabel.Location = new System.Drawing.Point(158, 40);
            this.BorrowerIDLabel.Name = "BorrowerIDLabel";
            this.BorrowerIDLabel.Size = new System.Drawing.Size(145, 20);
            this.BorrowerIDLabel.TabIndex = 15;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(458, 108);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(145, 20);
            this.PhoneTextBox.TabIndex = 13;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(458, 40);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(145, 20);
            this.AddressTextBox.TabIndex = 12;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(458, 173);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(145, 20);
            this.MailTextBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(158, 105);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(145, 20);
            this.NameTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(352, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Borrower Email";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(352, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Borrower Phone";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(352, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Borrower Address";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(52, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Borrower Gender";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(52, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Borrower Birth Date";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borrower Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower ID";
            // 
            // MonthCombobox
            // 
            this.MonthCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCombobox.FormattingEnabled = true;
            this.MonthCombobox.Location = new System.Drawing.Point(158, 222);
            this.MonthCombobox.Name = "MonthCombobox";
            this.MonthCombobox.Size = new System.Drawing.Size(45, 21);
            this.MonthCombobox.TabIndex = 24;
            // 
            // DayCombobox
            // 
            this.DayCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayCombobox.FormattingEnabled = true;
            this.DayCombobox.Location = new System.Drawing.Point(229, 221);
            this.DayCombobox.Name = "DayCombobox";
            this.DayCombobox.Size = new System.Drawing.Size(45, 21);
            this.DayCombobox.TabIndex = 25;
            // 
            // YearCombobox
            // 
            this.YearCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearCombobox.FormattingEnabled = true;
            this.YearCombobox.Location = new System.Drawing.Point(300, 221);
            this.YearCombobox.Name = "YearCombobox";
            this.YearCombobox.Size = new System.Drawing.Size(59, 21);
            this.YearCombobox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "( Month / Day / Year )";
            // 
            // AddBorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.panel1);
            this.Name = "AddBorrowerForm";
            this.Text = "AddBorrowerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BorrowerIDLabel;
        private System.Windows.Forms.RadioButton FemaleButton;
        private System.Windows.Forms.RadioButton MaleButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox YearCombobox;
        private System.Windows.Forms.ComboBox DayCombobox;
        private System.Windows.Forms.ComboBox MonthCombobox;
        private System.Windows.Forms.Label label9;
    }
}