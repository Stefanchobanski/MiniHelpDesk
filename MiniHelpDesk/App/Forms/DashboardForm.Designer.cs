namespace App.Forms
{
    partial class DashboardForm
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
            pnlSidebar = new Panel();
            lblTitle = new Label();
            lbUsernameTitle = new Label();
            lblUsername = new Label();
            btnCreate = new Button();
            btnViewTicket = new Button();
            pnlList = new Panel();
            lblListTitle = new Label();
            lbxTickets = new ListBox();
            pnlSidebar.SuspendLayout();
            pnlList.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Controls.Add(lbUsernameTitle);
            pnlSidebar.Controls.Add(lblUsername);
            pnlSidebar.Controls.Add(btnCreate);
            pnlSidebar.Controls.Add(btnViewTicket);
            pnlSidebar.Location = new Point(20, 20);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(320, 540);
            pnlSidebar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(30, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(117, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Начало";
            // 
            // lbUsernameTitle
            // 
            lbUsernameTitle.AutoSize = true;
            lbUsernameTitle.ForeColor = Color.FromArgb(77, 124, 138);
            lbUsernameTitle.Location = new Point(32, 58);
            lbUsernameTitle.Name = "lbUsernameTitle";
            lbUsernameTitle.Size = new Size(86, 15);
            lbUsernameTitle.TabIndex = 1;
            lbUsernameTitle.Text = "Добре дошли,";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(27, 64, 121);
            lblUsername.Location = new Point(32, 80);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(21, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "   ";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(27, 64, 121);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(30, 140);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(260, 38);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Създаване на тикет";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnViewTicket
            // 
            btnViewTicket.BackColor = Color.FromArgb(77, 124, 138);
            btnViewTicket.FlatAppearance.BorderSize = 0;
            btnViewTicket.FlatStyle = FlatStyle.Flat;
            btnViewTicket.ForeColor = Color.White;
            btnViewTicket.Location = new Point(30, 193);
            btnViewTicket.Name = "btnViewTicket";
            btnViewTicket.Size = new Size(260, 38);
            btnViewTicket.TabIndex = 4;
            btnViewTicket.Text = "Преглед на тикет";
            btnViewTicket.UseVisualStyleBackColor = false;
            btnViewTicket.Click += btnViewTicket_Click;
            // 
            // pnlList
            // 
            pnlList.BackColor = Color.FromArgb(245, 248, 252);
            pnlList.Controls.Add(lblListTitle);
            pnlList.Controls.Add(lbxTickets);
            pnlList.Location = new Point(360, 20);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(600, 540);
            pnlList.TabIndex = 1;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblListTitle.Location = new Point(20, 18);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(69, 20);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Преглед";
            // 
            // lbxTickets
            // 
            lbxTickets.BorderStyle = BorderStyle.None;
            lbxTickets.Font = new Font("Segoe UI", 10F);
            lbxTickets.FormattingEnabled = true;
            lbxTickets.Location = new Point(20, 50);
            lbxTickets.Name = "lbxTickets";
            lbxTickets.Size = new Size(560, 459);
            lbxTickets.TabIndex = 1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 580);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlList);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Начало";
            Load += DashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlList.ResumeLayout(false);
            pnlList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlList;
        private Label lblTitle;
        private Label lblListTitle;
        private Label lbUsernameTitle;
        private Label lblUsername;
        private ListBox lbxTickets;
        private Button btnCreate;
        private Button btnViewTicket;
    }
}