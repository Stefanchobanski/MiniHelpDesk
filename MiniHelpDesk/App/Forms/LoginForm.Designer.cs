namespace App.Forms
{
    partial class LoginForm
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
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            chkRevealPassword = new CheckBox();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chkRevealPassword
            // 
            chkRevealPassword.Location = new Point(40, 330);
            chkRevealPassword.Name = "chkRevealPassword";
            chkRevealPassword.Size = new Size(160, 24);
            chkRevealPassword.TabIndex = 7;
            chkRevealPassword.Text = "Покажи паролата";
            chkRevealPassword.CheckedChanged += chkRevealPassword_CheckedChanged;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.Controls.Add(pictureBox1);
            pnlBody.Controls.Add(lblTitle);
            pnlBody.Controls.Add(lblSubtitle);
            pnlBody.Controls.Add(lblUsername);
            pnlBody.Controls.Add(txtUsername);
            pnlBody.Controls.Add(lblPassword);
            pnlBody.Controls.Add(txtPassword);
            pnlBody.Controls.Add(chkRevealPassword);
            pnlBody.Controls.Add(btnLogin);
            pnlBody.Controls.Add(btnRegister);
            pnlBody.Location = new Point(35, 20);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(450, 477);
            pnlBody.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logopgtk;
            pictureBox1.Location = new Point(178, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(170, 110);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(91, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Вход";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(153, 155);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(129, 15);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Влезте в MiniHelpDesk";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(40, 200);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(150, 23);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Потребител";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(40, 225);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(370, 23);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(40, 270);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Парола";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 295);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(370, 23);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(27, 64, 121);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 370);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(370, 45);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(40, 425);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(370, 35);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Регистрация";
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 520);
            Controls.Add(pnlBody);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk - Вход";
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
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}