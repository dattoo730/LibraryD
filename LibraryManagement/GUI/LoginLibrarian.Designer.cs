namespace LibraryManagement.GUI
{
    partial class LoginLibrarian
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
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.userPass = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.Location = new System.Drawing.Point(172, 127);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(96, 17);
            this.checkShowPassword.TabIndex = 13;
            this.checkShowPassword.Text = "ShowPasswod";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(238, 160);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(130, 30);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(58, 160);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(130, 30);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(172, 79);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(196, 20);
            this.userPass.TabIndex = 10;
            this.userPass.TextChanged += new System.EventHandler(this.userPass_TextChanged);
            // 
            // lblPassWord
            // 
            this.lblPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.Location = new System.Drawing.Point(55, 82);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(100, 23);
            this.lblPassWord.TabIndex = 9;
            this.lblPassWord.Text = "PassWord";
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(172, 30);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(196, 20);
            this.userId.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(55, 31);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User :";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.ForeColor = System.Drawing.Color.Red;
            this.lblCorrect.Location = new System.Drawing.Point(172, 108);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(0, 13);
            this.lblCorrect.TabIndex = 14;
            // 
            // LoginLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 227);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.lblUser);
            this.Name = "LoginLibrarian";
            this.Text = "LoginLibrarian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkShowPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCorrect;
    }
}