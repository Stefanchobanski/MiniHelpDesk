using App.Forms;
using App.Services;
using App.Services.interfaces;
using App.Services.Interfaces;

namespace App
{
    public partial class RegisterForm : Form
    {
        private readonly IRegisterService _registerService;
        private readonly ILoginService _loginService;

        private readonly IAdminService _adminService;
        private readonly IRoleService _roleService;
        private readonly CategoryService _categoryService;
        private readonly TicketService _ticketService;

        public CheckBox chkRevealPassword;

        public RegisterForm(IRegisterService registerService, ILoginService loginService, IAdminService adminService, IRoleService roleService, CategoryService categoryService, TicketService ticketService)
        {
            InitializeComponent();
            _registerService = registerService;
            _loginService = loginService;
            _adminService = adminService;
            _roleService = roleService;
            _categoryService = categoryService;
            _ticketService = ticketService;
        }

        private void chkRevealPassword_CheckedChanged(object sender, EventArgs e)
        {
            chkRevealPassword = (CheckBox)sender;
            txtPassword.UseSystemPasswordChar = !chkRevealPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !chkRevealPassword.Checked;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (RegisterEventHelpers.CheckAllFieldsRegister(username, email, password, confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await _registerService.RegisterUser(username, email, password);

                MessageBox.Show("Registration successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var loginForm = new LoginForm(_loginService, this, _adminService, _roleService, _categoryService, _ticketService);
                loginForm.FormClosed += (s, args) => this.Show();
                loginForm.Show();
                this.Hide();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(_loginService, this, _adminService, _roleService, _categoryService, _ticketService);
            loginForm.FormClosed += (s, args) => this.Show();
            loginForm.Show();
            this.Hide();
        }
    }
}