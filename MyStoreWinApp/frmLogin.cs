using System;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private IMemberRepository memRepository = new MemberRepository();
        public IMemberRepository MemRepository { get => memRepository; set => memRepository = value; }

        frmMemberManagement frmMemeberManagement = new frmMemberManagement();

        public static string role = "";
        public static string emailUser = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool login = MemRepository.Login(txtEmail.Text, txtPassword.Text);
                if (txtEmail.Text.Contains("admin")) role = "Admin";
                else role = "Member";

                if (login)
                {
                    MessageBox.Show("SUCCESS!", $"{role} Login");
                    emailUser = txtEmail.Text;
                }
                else
                {
                    MessageBox.Show("FAILED");
                }
                CheckLogin(login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CheckLogin(bool flag)
        {
            if (flag == true)
            {
                frmMemeberManagement.Show();
            }
        }
    }
}