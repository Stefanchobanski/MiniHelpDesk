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
            chkRevealPassword = new CheckBox();
            SuspendLayout();
            // 
            // chkRevealPassword
            // 
            chkRevealPassword.AutoSize = true;
            chkRevealPassword.Location = new Point(112, 685);
            chkRevealPassword.Name = "chkRevealPassword";
            chkRevealPassword.Size = new Size(179, 32);
            chkRevealPassword.TabIndex = 11;
            chkRevealPassword.Text = "Покажи парола";
            chkRevealPassword.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(134, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Регистрационна форма";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13F);
            lblUsername.Location = new Point(176, 185);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(216, 30);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Име на потребител:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(112, 232);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(358, 34);
            txtUsername.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(243, 287);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(78, 28);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Имейл:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(236, 500);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Парола:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(151, 600);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(263, 28);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Потвърждаване на парола:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(112, 318);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 34);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 531);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(358, 34);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(112, 631);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(358, 34);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // cbxRole
            // 
            cbxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRole.FormattingEnabled = true;
            cbxRole.Items.AddRange(new object[] { "Администратор", "Техник", "Заявител" });
            cbxRole.Location = new Point(112, 434);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(358, 36);
            cbxRole.TabIndex = 9;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(252, 387);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(60, 28);
            lblRole.TabIndex = 10;
            lblRole.Text = "Роля:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(112, 743);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(358, 50);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Регистрирация";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 903);
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
            Margin = new Padding(4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
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
    }
}
