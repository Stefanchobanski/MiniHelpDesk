namespace App
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            CheckBox chkRevealPassword;
            pnlBody = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            chkRevealPassword = new CheckBox();

            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 660);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk - Регистрация";
            Font = new Font("Segoe UI", 9F);
            Controls.Add(pnlBody);

            // ── pnlBody ───────────────────────────────────────────
            pnlBody.BackColor = Color.White;
            pnlBody.Location = new Point(35, 20);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(450, 620);
            pnlBody.TabIndex = 0;
            pnlBody.Controls.Add(pictureBox1);
            pnlBody.Controls.Add(lblTitle);
            pnlBody.Controls.Add(lblSubtitle);
            pnlBody.Controls.Add(lblUsername);
            pnlBody.Controls.Add(txtUsername);
            pnlBody.Controls.Add(lblEmail);
            pnlBody.Controls.Add(txtEmail);
            pnlBody.Controls.Add(lblPassword);
            pnlBody.Controls.Add(txtPassword);
            pnlBody.Controls.Add(lblConfirmPassword);
            pnlBody.Controls.Add(txtConfirmPassword);
            pnlBody.Controls.Add(chkRevealPassword);
            pnlBody.Controls.Add(btnRegister);
            pnlBody.Controls.Add(btnLogin);

            // ── pictureBox1 ───────────────────────────────────────
            pictureBox1.Image = Properties.Resources.logopgtk;
            pictureBox1.Location = new Point(178, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            // ── lblTitle ──────────────────────────────────────────
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(105, 110);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Регистрация";

            // ── lblSubtitle ───────────────────────────────────────
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(109, 155);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Създайте акаунт в MiniHelpDesk";

            // ── lblUsername ───────────────────────────────────────
            lblUsername.Location = new Point(40, 195);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(150, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Потребител";

            // ── txtUsername ───────────────────────────────────────
            txtUsername.Location = new Point(40, 218);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(370, 23);
            txtUsername.TabIndex = 4;

            // ── lblEmail ──────────────────────────────────────────
            lblEmail.Location = new Point(40, 260);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(150, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Имейл";

            // ── txtEmail ──────────────────────────────────────────
            txtEmail.Location = new Point(40, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 23);
            txtEmail.TabIndex = 6;

            // ── lblPassword ───────────────────────────────────────
            lblPassword.Location = new Point(40, 325);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Парола";

            // ── txtPassword ───────────────────────────────────────
            txtPassword.Location = new Point(40, 348);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(370, 23);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;

            // ── lblConfirmPassword ────────────────────────────────
            lblConfirmPassword.Location = new Point(40, 390);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(150, 20);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Потвърди паролата";

            // ── txtConfirmPassword ────────────────────────────────
            txtConfirmPassword.Location = new Point(40, 413);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(370, 23);
            txtConfirmPassword.TabIndex = 10;
            txtConfirmPassword.UseSystemPasswordChar = true;

            // ── chkRevealPassword ─────────────────────────────────
            chkRevealPassword.Location = new Point(40, 450);
            chkRevealPassword.Name = "chkRevealPassword";
            chkRevealPassword.Size = new Size(160, 24);
            chkRevealPassword.TabIndex = 11;
            chkRevealPassword.Text = "Покажи паролата";
            chkRevealPassword.CheckedChanged += chkRevealPassword_CheckedChanged;

            // ── btnRegister ───────────────────────────────────────
            btnRegister.BackColor = Color.FromArgb(27, 64, 121);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(40, 490);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(370, 45);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;

            // ── btnLogin ──────────────────────────────────────────
            btnLogin.Location = new Point(40, 548);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(370, 35);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Вече имам акаунт → Вход";
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(27, 64, 121);
            btnLogin.ForeColor = Color.FromArgb(27, 64, 121);
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;

            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBody;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnLogin;
    }
}