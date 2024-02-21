namespace MyStoreWinApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbLogin = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(150, 35);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(42, 15);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "LOGIN";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(44, 84);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(44, 130);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(124, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(161, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(134, 189);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(134, 261);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 387);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbLogin);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label lbEmail;
        private Label lbPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}