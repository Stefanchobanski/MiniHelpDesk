namespace App.Forms
{
    partial class UserForm
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
            lblUsername = new Label();
            txtbUsername = new TextBox();
            lblEmail = new Label();
            txtbEmail = new TextBox();
            lblRole = new Label();
            cmbRoles = new ComboBox();
            btnShowTickets = new Button();
            btnRemoveUser = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            pnlList = new Panel();
            lblListTitle = new Label();
            lbUsers = new ListBox();

            pnlSidebar.SuspendLayout();
            pnlList.SuspendLayout();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 580);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Потребители";
            Font = new Font("Segoe UI", 9F);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlList);
            Load += UserForm_Load;

            // ── pnlSidebar (left panel) ───────────────────────────
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Location = new Point(20, 20);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(320, 540);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Controls.Add(lblSubtitle);
            pnlSidebar.Controls.Add(lblUsername);
            pnlSidebar.Controls.Add(txtbUsername);
            pnlSidebar.Controls.Add(lblEmail);
            pnlSidebar.Controls.Add(txtbEmail);
            pnlSidebar.Controls.Add(lblRole);
            pnlSidebar.Controls.Add(cmbRoles);
            pnlSidebar.Controls.Add(btnShowTickets);
            pnlSidebar.Controls.Add(btnRemoveUser);
            pnlSidebar.Controls.Add(btnUpdate);
            pnlSidebar.Controls.Add(btnBack);

            // ── lblTitle ──────────────────────────────────────────
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(60, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Потребители";

            // ── lblSubtitle ───────────────────────────────────────
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(62, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Управление на акаунти";

            // ── lblUsername ───────────────────────────────────────
            lblUsername.Location = new Point(30, 105);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(260, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Потребител";
            lblUsername.ForeColor = Color.FromArgb(27, 64, 121);

            // ── txtbUsername ──────────────────────────────────────
            txtbUsername.Enabled = false;
            txtbUsername.Location = new Point(30, 128);
            txtbUsername.Name = "txtbUsername";
            txtbUsername.Size = new Size(260, 23);
            txtbUsername.TabIndex = 3;
            txtbUsername.BorderStyle = BorderStyle.FixedSingle;

            // ── lblEmail ──────────────────────────────────────────
            lblEmail.Location = new Point(30, 172);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(260, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Имейл";
            lblEmail.ForeColor = Color.FromArgb(27, 64, 121);

            // ── txtbEmail ─────────────────────────────────────────
            txtbEmail.Enabled = false;
            txtbEmail.Location = new Point(30, 195);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(260, 23);
            txtbEmail.TabIndex = 5;
            txtbEmail.BorderStyle = BorderStyle.FixedSingle;

            // ── lblRole ───────────────────────────────────────────
            lblRole.Location = new Point(30, 240);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(260, 20);
            lblRole.TabIndex = 6;
            lblRole.Text = "Роля";
            lblRole.ForeColor = Color.FromArgb(27, 64, 121);

            // ── cmbRoles ──────────────────────────────────────────
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(30, 263);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(260, 23);
            cmbRoles.TabIndex = 7;
            //cmbRoles.FlatStyle = FlatStyle.Flat;

            // ── btnShowTickets ────────────────────────────────────
            btnShowTickets.BackColor = Color.FromArgb(77, 124, 138);
            btnShowTickets.FlatStyle = FlatStyle.Flat;
            btnShowTickets.FlatAppearance.BorderSize = 0;
            btnShowTickets.ForeColor = Color.White;
            btnShowTickets.Location = new Point(30, 320);
            btnShowTickets.Name = "btnShowTickets";
            btnShowTickets.Size = new Size(260, 38);
            btnShowTickets.TabIndex = 8;
            btnShowTickets.Text = "Преглед на тикети";
            btnShowTickets.UseVisualStyleBackColor = false;
            btnShowTickets.Click += btnShowTickets_Click;

            // ── btnUpdate ─────────────────────────────────────────
            btnUpdate.BackColor = Color.FromArgb(27, 64, 121);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(30, 373);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(260, 38);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Запази промените";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            // ── btnRemoveUser ─────────────────────────────────────
            btnRemoveUser.BackColor = Color.FromArgb(180, 50, 50);
            btnRemoveUser.FlatStyle = FlatStyle.Flat;
            btnRemoveUser.FlatAppearance.BorderSize = 0;
            btnRemoveUser.ForeColor = Color.White;
            btnRemoveUser.Location = new Point(30, 426);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(260, 38);
            btnRemoveUser.TabIndex = 10;
            btnRemoveUser.Text = "Премахни потребител";
            btnRemoveUser.UseVisualStyleBackColor = false;
            btnRemoveUser.Click += btnRemoveUser_Click;

            // ── btnBack ───────────────────────────────────────────
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(27, 64, 121);
            btnBack.ForeColor = Color.FromArgb(27, 64, 121);
            btnBack.Location = new Point(30, 487);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(260, 35);
            btnBack.TabIndex = 11;
            btnBack.Text = "← Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // ── pnlList (right panel) ─────────────────────────────
            pnlList.BackColor = Color.FromArgb(245, 248, 252);
            pnlList.Location = new Point(360, 20);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(600, 540);
            pnlList.TabIndex = 1;
            pnlList.Controls.Add(lblListTitle);
            pnlList.Controls.Add(lbUsers);

            // ── lblListTitle ──────────────────────────────────────
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblListTitle.Location = new Point(20, 18);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Списък с потребители";

            // ── lbUsers ───────────────────────────────────────────
            lbUsers.BorderStyle = BorderStyle.None;
            lbUsers.Font = new Font("Segoe UI", 10F);
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 28;
            lbUsers.Location = new Point(20, 50);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(560, 475);
            lbUsers.TabIndex = 1;
            lbUsers.SelectedIndexChanged += lbUsers_SelectedIndexChanged;

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
        private Label lblUsername;
        private Label lblEmail;
        private Label lblRole;
        private TextBox txtbUsername;
        private TextBox txtbEmail;
        private ComboBox cmbRoles;
        private ListBox lbUsers;
        private Button btnShowTickets;
        private Button btnUpdate;
        private Button btnRemoveUser;
        private Button btnBack;
    }
}