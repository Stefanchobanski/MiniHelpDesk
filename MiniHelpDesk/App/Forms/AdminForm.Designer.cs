namespace App.Forms
{
    partial class AdminForm
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
            lblTitle = new Label();
            btnUsers = new Button();
            btnCategories = new Button();
            btnRoles = new Button();
            btnReport = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(106, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(113, 21);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Admin панел";
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(106, 82);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(109, 41);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(106, 151);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(109, 41);
            btnCategories.TabIndex = 8;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnRoles
            // 
            btnRoles.Location = new Point(106, 216);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(109, 41);
            btnRoles.TabIndex = 9;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(106, 281);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(109, 41);
            btnReport.TabIndex = 10;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 402);
            Controls.Add(btnReport);
            Controls.Add(btnRoles);
            Controls.Add(btnCategories);
            Controls.Add(btnUsers);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAllTickets;
        private Label lblTitle;
        private TextBox txtInfo1;
        private TextBox txtInfo2;
        private TextBox txtInfo3;
        private Button btnUsers;
        private Button btnCategories;
        private Button btnRoles;
        private Button btnReport;
    }
}