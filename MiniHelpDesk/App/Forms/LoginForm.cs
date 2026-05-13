using App.Services.Interfaces;

namespace App.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ILoginService _loginService;

        public CheckBox chkRevealPassword;

        public LoginForm(ILoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
        }

        private void chkRevealPassword_CheckedChanged(object sender, EventArgs e)
        {
            chkRevealPassword = (CheckBox)sender;
            if (chkRevealPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (RegisterEventHelpers.CheckAllFieldsLogin(username, password))
            {
                MessageBox.Show("Please fill in all fields to log in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
