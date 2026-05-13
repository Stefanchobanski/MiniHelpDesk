using App.Forms;
using App.Services.interfaces;

namespace App
{
    public partial class RegisterForm : Form
    {
        private readonly IRegisterService _registerService;

        public CheckBox chkRevealPassword;

        public RegisterForm(IRegisterService registerService)
        {
            InitializeComponent();
            _registerService = registerService;
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

                var loginForm = new LoginForm();
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
    }
}