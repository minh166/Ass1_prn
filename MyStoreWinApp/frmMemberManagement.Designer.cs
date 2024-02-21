namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            lbTitle = new Label();
            lbMemberId = new Label();
            txtMemberName = new TextBox();
            txtMemberId = new TextBox();
            lbMemberName = new Label();
            lbCity = new Label();
            lbEmail = new Label();
            txtCity = new TextBox();
            txtEmail = new TextBox();
            lbCountry = new Label();
            txtCountry = new TextBox();
            dgvMember = new DataGridView();
            btnInsert = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            lbPassword = new Label();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(271, 36);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(140, 15);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "MEMBER MANAGEMENT";
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(52, 74);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(66, 15);
            lbMemberId.TabIndex = 1;
            lbMemberId.Text = "Member ID";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(158, 116);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(154, 23);
            txtMemberName.TabIndex = 4;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(158, 71);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(154, 23);
            txtMemberId.TabIndex = 2;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(52, 119);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(87, 15);
            lbMemberName.TabIndex = 3;
            lbMemberName.Text = "Member Name";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(405, 74);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 7;
            lbCity.Text = "City";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(52, 166);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(478, 71);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(154, 23);
            txtCity.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 6;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(405, 119);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 9;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(478, 116);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(154, 23);
            txtCountry.TabIndex = 10;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(12, 207);
            dgvMember.Name = "dgvMember";
            dgvMember.RowTemplate.Height = 25;
            dgvMember.Size = new Size(663, 177);
            dgvMember.TabIndex = 11;
            dgvMember.CellContentClick += dgvMember_CellContentClick;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(52, 390);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(557, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(219, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(380, 390);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Modify";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(398, 166);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 16;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(478, 163);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(154, 23);
            txtPassword.TabIndex = 17;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 433);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnInsert);
            Controls.Add(dgvMember);
            Controls.Add(txtMemberId);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtEmail);
            Controls.Add(txtCity);
            Controls.Add(txtMemberName);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbEmail);
            Controls.Add(lbCity);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberId);
            Controls.Add(lbTitle);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbMemberId;
        private TextBox txtMemberName;
        private TextBox txtMemberId;
        private Label lbMemberName;
        private Label lbCity;
        private Label lbEmail;
        private TextBox txtCity;
        private TextBox txtEmail;
        private Label lbCountry;
        private TextBox txtCountry;
        private DataGridView dgvMember;
        private Button btnInsert;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lbPassword;
        private TextBox txtPassword;
    }
}