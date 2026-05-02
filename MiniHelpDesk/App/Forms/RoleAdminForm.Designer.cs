namespace App.Forms
{
    partial class RoleAdminForm
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
            btnBack = new Button();
            btnUpdate = new Button();
            btnRemoveUser = new Button();
            txtbName = new TextBox();
            lblName = new Label();
            lbRoles = new ListBox();
            btnAddRole = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(79, 483);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 44);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(79, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 44);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.Location = new Point(79, 335);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(119, 44);
            btnRemoveUser.TabIndex = 19;
            btnRemoveUser.Text = "Remove";
            btnRemoveUser.UseVisualStyleBackColor = true;
            btnRemoveUser.Click += btnRemoveUser_Click;
            // 
            // txtbName
            // 
            txtbName.Enabled = false;
            txtbName.Location = new Point(79, 167);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(146, 29);
            txtbName.TabIndex = 17;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(124, 143);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 21);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // lbRoles
            // 
            lbRoles.FormattingEnabled = true;
            lbRoles.Location = new Point(403, 40);
            lbRoles.Margin = new Padding(4);
            lbRoles.Name = "lbRoles";
            lbRoles.Size = new Size(546, 487);
            lbRoles.TabIndex = 12;
            lbRoles.SelectedIndexChanged += lbRoles_SelectedIndexChanged;
            // 
            // btnAddRole
            // 
            btnAddRole.Location = new Point(79, 267);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(119, 44);
            btnAddRole.TabIndex = 22;
            btnAddRole.Text = "Add";
            btnAddRole.UseVisualStyleBackColor = true;
            btnAddRole.Click += btnAddRole_Click;
            // 
            // RoleAdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnAddRole);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemoveUser);
            Controls.Add(txtbName);
            Controls.Add(lblName);
            Controls.Add(lbRoles);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "RoleAdminForm";
            Text = "RoleAdminForm";
            Load += RoleAdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnUpdate;
        private Button btnRemoveUser;
        private TextBox txtbName;
        private Label lblName;
        private ListBox lbRoles;
        private Button btnAddRole;
    }
}