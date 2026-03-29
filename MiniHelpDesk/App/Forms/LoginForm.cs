namespace App.Forms
{
    public partial class LoginForm : Form
    {
        public CheckBox chkRevealPassword;
        public LoginForm()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
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
