using App.Models;
using App.Services.interfaces;
using MiniHelpDesk.Services;

namespace App
{
    public partial class RegisterForm : Form
    {
        private readonly IRegisterService _registerService;
        private readonly IRoleService _roleService;

        public CheckBox chkRevealPassword;
        public RegisterForm(IRegisterService registerService, IRoleService roleService)
        {
            InitializeComponent();
            _registerService = registerService;
            _roleService = roleService;
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
            if (password.Length < 6 && confirmPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbxRole.SelectedIndex < 0)
            {
                MessageBox.Show("Not selected item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User()
            {
                Username = username,
                Email = email,
                Password = password,
                RoleID = (int)cbxRole.SelectedValue
            };

            _registerService.AddUser(user);
        }

        private async void RegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                var roles = await _roleService.GetRolesAsync();
                cbxRole.DataSource = roles;
                cbxRole.DisplayMember = "Name";
                cbxRole.ValueMember = "RoleID";

                cbxRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
