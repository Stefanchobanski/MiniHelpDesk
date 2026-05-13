using App.Services;
using App.Services.interfaces;
using App.Services.Interfaces;
using System.CodeDom;

namespace App.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ILoginService _loginService;
        private readonly RegisterForm _registerForm;

        private readonly IAdminService _adminService;
        private readonly IRoleService _roleService;
        private readonly CategoryService _categoryService;
        private readonly TicketService _ticketService;

        public CheckBox chkRevealPassword;

        public LoginForm(ILoginService loginService, RegisterForm registerForm, IAdminService adminService, IRoleService roleService, CategoryService categoryService, TicketService ticketService)
        {
            InitializeComponent();
            _loginService = loginService;
            _registerForm = registerForm;
            _adminService = adminService;
            _roleService = roleService;
            _categoryService = categoryService;
            _ticketService = ticketService;
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
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (RegisterEventHelpers.CheckAllFieldsLogin(username, password))
                {
                    MessageBox.Show("Please fill in all fields to log in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string role = await _loginService.LoginAsync(username, password);



                Form nextForm = default;
                switch (role)
                {
                    case "Admin":
                        nextForm = new AdminForm(_adminService, _roleService, _categoryService, _ticketService);
                        break;
                    case "Requester":
                        break;
                    case "Technician":
                        break;
                    case "Null":
                        break;
                    default:
                        MessageBox.Show("Невалидна роля!");
                        return;
                }

                this.Hide();
                nextForm.FormClosed += (s, args) => this.Show();
                nextForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("login error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _registerForm.Show();
            _registerForm.FormClosed += (s, args) => this.Close();
            this.Close();
        }
    }
}
