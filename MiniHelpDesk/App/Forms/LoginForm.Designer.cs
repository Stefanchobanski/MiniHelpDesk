namespace App.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CheckBox chkRevealPassword;
            lblMiniHelpDesk = new Label();
            pictureBoxPgtk = new PictureBox();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            chkRevealPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPgtk).BeginInit();
            SuspendLayout();
            // 
            // lblMiniHelpDesk
            // 
            lblMiniHelpDesk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMiniHelpDesk.AutoSize = true;
            lblMiniHelpDesk.Font = new Font("Segoe UI", 25F);
            lblMiniHelpDesk.Location = new Point(172, 91);
            lblMiniHelpDesk.Name = "lblMiniHelpDesk";
            lblMiniHelpDesk.Size = new Size(229, 46);
            lblMiniHelpDesk.TabIndex = 17;
            lblMiniHelpDesk.Text = "MiniHelpDesk";
            // 
            // pictureBoxPgtk
            // 
            pictureBoxPgtk.Image = Properties.Resources.logopgtk;
            pictureBoxPgtk.Location = new Point(82, 62);
            pictureBoxPgtk.Name = "pictureBoxPgtk";
            pictureBoxPgtk.Size = new Size(100, 100);
            pictureBoxPgtk.TabIndex = 16;
            pictureBoxPgtk.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 17F);
            lblTitle.Location = new Point(242, 155);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(64, 31);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "Вход";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 13F);
            lblUsername.Location = new Point(112, 204);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(173, 25);
            lblUsername.TabIndex = 19;
            lblUsername.Text = "Име на потребител:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(112, 232);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(358, 23);
            txtUsername.TabIndex = 20;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F);
            lblPassword.Location = new Point(112, 290);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 25);
            lblPassword.TabIndex = 21;
            lblPassword.Text = "Парола:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 318);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(358, 23);
            txtPassword.TabIndex = 22;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 13F);
            btnLogin.Location = new Point(112, 393);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(358, 50);
            btnLogin.TabIndex = 23;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkRevealPassword
            // 
            chkRevealPassword.AutoSize = true;
            chkRevealPassword.Font = new Font("Segoe UI", 13F);
            chkRevealPassword.Location = new Point(112, 347);
            chkRevealPassword.Name = "chkRevealPassword";
            chkRevealPassword.Size = new Size(160, 29);
            chkRevealPassword.TabIndex = 24;
            chkRevealPassword.Text = "Покажи парола";
            chkRevealPassword.UseVisualStyleBackColor = true;
            chkRevealPassword.CheckedChanged += chkRevealPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 528);
            Controls.Add(chkRevealPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Controls.Add(lblMiniHelpDesk);
            Controls.Add(pictureBoxPgtk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPgtk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMiniHelpDesk;
        private PictureBox pictureBoxPgtk;
        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}