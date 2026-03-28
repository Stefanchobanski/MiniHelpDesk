namespace App
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CheckBox chkRevealPassword;
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            cbxRole = new ComboBox();
            lblRole = new Label();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            lblMiniHelpDesk = new Label();
            chkRevealPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chkRevealPassword
            // 
            chkRevealPassword.AutoSize = true;
            chkRevealPassword.Font = new Font("Segoe UI", 13F);
            chkRevealPassword.Location = new Point(112, 642);
            chkRevealPassword.Name = "chkRevealPassword";
            chkRevealPassword.Size = new Size(160, 29);
            chkRevealPassword.TabIndex = 11;
            chkRevealPassword.Text = "Покажи парола";
            chkRevealPassword.UseVisualStyleBackColor = true;
            chkRevealPassword.CheckedChanged += chkRevealPassword_CheckedChanged;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(160, 155);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Регистрационна форма";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13F);
            lblUsername.Location = new Point(112, 204);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(173, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Име на потребител:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(112, 232);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(358, 29);
            txtUsername.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13F);
            lblEmail.Location = new Point(112, 290);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Имейл:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F);
            lblPassword.Location = new Point(112, 479);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Парола:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 13F);
            lblConfirmPassword.Location = new Point(112, 579);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(237, 25);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Потвърждаване на парола:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(112, 318);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 29);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 507);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(358, 29);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(112, 607);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(358, 29);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // cbxRole
            // 
            cbxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRole.FormattingEnabled = true;
            cbxRole.Items.AddRange(new object[] { "Администратор", "Техник", "Заявител" });
            cbxRole.Location = new Point(112, 414);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(358, 29);
            cbxRole.TabIndex = 9;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 13F);
            lblRole.Location = new Point(112, 386);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 25);
            lblRole.TabIndex = 10;
            lblRole.Text = "Роля:";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 13F);
            btnRegister.Location = new Point(112, 743);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(358, 50);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Регистрирация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logopgtk;
            pictureBox1.Location = new Point(82, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblMiniHelpDesk
            // 
            lblMiniHelpDesk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMiniHelpDesk.AutoSize = true;
            lblMiniHelpDesk.Font = new Font("Segoe UI", 25F);
            lblMiniHelpDesk.Location = new Point(172, 91);
            lblMiniHelpDesk.Name = "lblMiniHelpDesk";
            lblMiniHelpDesk.Size = new Size(229, 46);
            lblMiniHelpDesk.TabIndex = 14;
            lblMiniHelpDesk.Text = "MiniHelpDesk";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 881);
            Controls.Add(lblMiniHelpDesk);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(chkRevealPassword);
            Controls.Add(lblRole);
            Controls.Add(cbxRole);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ComboBox cbxRole;
        private Label lblRole;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label lblMiniHelpDesk;
    }
}
