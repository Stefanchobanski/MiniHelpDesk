using App.Models;
using MiniHelpDesk.Services;

namespace App
{
    public partial class RegisterForm : Form
    {
        private readonly RegisterService _registerService;
        public CheckBox chkRevealPassword;
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void chkRevealPassword_CheckedChanged(object sender, EventArgs e)
        {
            chkRevealPassword = (CheckBox)sender;
            if (chkRevealPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            var roleId = cbxRole.SelectedValue;

            if (RegisterEventHelpers.CheckAllFieldsRegister(username, email, password, confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(password.Length < 6 && confirmPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User()
            {
                Username = username,
                Email = email,
                Password = password,
            };
        }

    }
}
