namespace App.Forms
{
    partial class TechnicianForm
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
            lblSubtitle = new Label();
            btnViewTickets = new Button();
            pnlList = new Panel();
            lblListTitle = new Label();
            lbUsers = new ListBox();
            pnlSidebar.SuspendLayout();
            pnlList.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Controls.Add(lblSubtitle);
            pnlSidebar.Controls.Add(btnViewTickets);
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
            lblTitle.Size = new Size(110, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Техник";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(32, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(169, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Преглед на назначени тикети";
            // 
            // btnViewTickets
            // 
            btnViewTickets.BackColor = Color.FromArgb(27, 64, 121);
            btnViewTickets.FlatAppearance.BorderSize = 0;
            btnViewTickets.FlatStyle = FlatStyle.Flat;
            btnViewTickets.ForeColor = Color.White;
            btnViewTickets.Location = new Point(30, 120);
            btnViewTickets.Name = "btnViewTickets";
            btnViewTickets.Size = new Size(260, 38);
            btnViewTickets.TabIndex = 2;
            btnViewTickets.Text = "🎫  Виж тикет";
            btnViewTickets.UseVisualStyleBackColor = false;
            btnViewTickets.Click += btnViewTickets_Click;
            // 
            // pnlList
            // 
            pnlList.BackColor = Color.FromArgb(245, 248, 252);
            pnlList.Controls.Add(lblListTitle);
            pnlList.Controls.Add(lbUsers);
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
            lblListTitle.Size = new Size(139, 20);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Назначени тикети";
            // 
            // lbUsers
            // 
            lbUsers.BorderStyle = BorderStyle.None;
            lbUsers.Font = new Font("Segoe UI", 10F);
            lbUsers.FormattingEnabled = true;
            lbUsers.Location = new Point(20, 50);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(560, 459);
            lbUsers.TabIndex = 1;
            // 
            // TechnicianForm
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
            Name = "TechnicianForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Техник";
            Load += TechnicianForm_Load;
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
        private Label lblSubtitle;
        private Label lblListTitle;
        private ListBox lbUsers;
        private Button btnViewTickets;
    }
}