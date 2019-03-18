﻿namespace LibraryManagement.GUI
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.DateTimePicker);
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
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(147, 227);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.DateTimePicker.TabIndex = 22;
            this.DateTimePicker.Value = new System.DateTime(2019, 3, 15, 0, 10, 47, 0);
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
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FemaleButton
            // 
            this.FemaleButton.Location = new System.Drawing.Point(223, 175);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(69, 20);
            this.FemaleButton.TabIndex = 17;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            // 
            // MaleButton
            // 
            this.MaleButton.Checked = true;
            this.MaleButton.Location = new System.Drawing.Point(147, 175);
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
            this.BorrowerIDLabel.Location = new System.Drawing.Point(147, 42);
            this.BorrowerIDLabel.Name = "BorrowerIDLabel";
            this.BorrowerIDLabel.Size = new System.Drawing.Size(145, 20);
            this.BorrowerIDLabel.TabIndex = 15;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(447, 110);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(145, 20);
            this.PhoneTextBox.TabIndex = 13;
            this.PhoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneTextBox_Validating);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(447, 42);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(145, 20);
            this.AddressTextBox.TabIndex = 12;
            this.AddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressTextBox_Validating);
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(447, 175);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(145, 20);
            this.MailTextBox.TabIndex = 10;
            this.MailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MailTextBox_Validating);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(147, 107);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(145, 20);
            this.NameTextBox.TabIndex = 8;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(341, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Borrower Email";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(341, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Borrower Phone";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(341, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Borrower Address";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(41, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Borrower Gender";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Borrower Birth Date";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borrower Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower ID";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddBorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.panel1);
            this.Name = "AddBorrowerForm";
            this.Text = "AddBorrowerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}