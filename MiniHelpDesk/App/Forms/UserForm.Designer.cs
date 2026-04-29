namespace App.Forms
{
    partial class UserForm
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
            lbUsers = new ListBox();
            lblUsername = new Label();
            lblEmail = new Label();
            cmbRoles = new ComboBox();
            lblRole = new Label();
            txtbUsername = new TextBox();
            txtbEmail = new TextBox();
            btnRemoveUser = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            btnShowTickets = new Button();
            SuspendLayout();
            // 
            // lbUsers
            // 
            lbUsers.FormattingEnabled = true;
            lbUsers.Location = new Point(396, 39);
            lbUsers.Margin = new Padding(4);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(546, 487);
            lbUsers.TabIndex = 0;
            lbUsers.SelectedIndexChanged += lbUsers_SelectedIndexChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(100, 63);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(81, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(112, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // cmbRoles
            // 
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(72, 236);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(146, 29);
            cmbRoles.TabIndex = 4;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(112, 212);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(41, 21);
            lblRole.TabIndex = 5;
            lblRole.Text = "Role";
            // 
            // txtbUsername
            // 
            txtbUsername.Enabled = false;
            txtbUsername.Location = new Point(72, 87);
            txtbUsername.Name = "txtbUsername";
            txtbUsername.Size = new Size(146, 29);
            txtbUsername.TabIndex = 6;
            // 
            // txtbEmail
            // 
            txtbEmail.Enabled = false;
            txtbEmail.Location = new Point(72, 159);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(146, 29);
            txtbEmail.TabIndex = 7;
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.Location = new Point(72, 412);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(119, 44);
            btnRemoveUser.TabIndex = 8;
            btnRemoveUser.Text = "Remove";
            btnRemoveUser.UseVisualStyleBackColor = true;
            btnRemoveUser.Click += btnRemoveUser_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(72, 471);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(72, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 44);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnShowTickets
            // 
            btnShowTickets.Location = new Point(72, 353);
            btnShowTickets.Name = "btnShowTickets";
            btnShowTickets.Size = new Size(119, 44);
            btnShowTickets.TabIndex = 11;
            btnShowTickets.Text = "View tickets";
            btnShowTickets.UseVisualStyleBackColor = true;
            btnShowTickets.Visible = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnShowTickets);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemoveUser);
            Controls.Add(txtbEmail);
            Controls.Add(txtbUsername);
            Controls.Add(lblRole);
            Controls.Add(cmbRoles);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lbUsers);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbUsers;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblRole;
        private ComboBox cmbRoles;
        private Label label4;
        private TextBox txtbUsername;
        private TextBox txtbEmail;
        private TextBox textBox3;
        private Button btnRemoveUser;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnShowTickets;
    }
}