namespace App.Forms
{
    partial class RoleAdminForm
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
            lblName = new Label();
            txtbName = new TextBox();
            btnAddRole = new Button();
            btnUpdate = new Button();
            btnRemoveUser = new Button();
            btnBack = new Button();
            pnlList = new Panel();
            lblListTitle = new Label();
            lbRoles = new ListBox();

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
            Name = "RoleAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Роли";
            Font = new Font("Segoe UI", 9F);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlList);
            Load += RoleAdminForm_Load;

            // ── pnlSidebar (left panel) ───────────────────────────
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Location = new Point(20, 20);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(320, 540);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Controls.Add(lblSubtitle);
            pnlSidebar.Controls.Add(lblName);
            pnlSidebar.Controls.Add(txtbName);
            pnlSidebar.Controls.Add(btnAddRole);
            pnlSidebar.Controls.Add(btnUpdate);
            pnlSidebar.Controls.Add(btnRemoveUser);
            pnlSidebar.Controls.Add(btnBack);

            // ── lblTitle ──────────────────────────────────────────
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(30, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Роли";

            // ── lblSubtitle ───────────────────────────────────────
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(32, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Управление на роли";

            // ── lblName ───────────────────────────────────────────
            lblName.Location = new Point(30, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(260, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Наименование";
            lblName.ForeColor = Color.FromArgb(27, 64, 121);

            // ── txtbName ──────────────────────────────────────────
            txtbName.Enabled = false;
            txtbName.Location = new Point(30, 138);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(260, 23);
            txtbName.TabIndex = 3;
            txtbName.BorderStyle = BorderStyle.FixedSingle;

            // ── btnAddRole ────────────────────────────────────────
            btnAddRole.BackColor = Color.FromArgb(77, 124, 138);
            btnAddRole.FlatStyle = FlatStyle.Flat;
            btnAddRole.FlatAppearance.BorderSize = 0;
            btnAddRole.ForeColor = Color.White;
            btnAddRole.Location = new Point(30, 185);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(260, 38);
            btnAddRole.TabIndex = 4;
            btnAddRole.Text = "➕  Добави роля";
            btnAddRole.UseVisualStyleBackColor = false;
            btnAddRole.Click += btnAddRole_Click;

            // ── btnUpdate ─────────────────────────────────────────
            btnUpdate.BackColor = Color.FromArgb(27, 64, 121);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(30, 238);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(260, 38);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "💾  Запази промените";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            // ── btnRemoveUser ─────────────────────────────────────
            btnRemoveUser.BackColor = Color.FromArgb(180, 50, 50);
            btnRemoveUser.FlatStyle = FlatStyle.Flat;
            btnRemoveUser.FlatAppearance.BorderSize = 0;
            btnRemoveUser.ForeColor = Color.White;
            btnRemoveUser.Location = new Point(30, 291);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(260, 38);
            btnRemoveUser.TabIndex = 6;
            btnRemoveUser.Text = "🗑️  Премахни роля";
            btnRemoveUser.UseVisualStyleBackColor = false;
            btnRemoveUser.Click += btnRemoveUser_Click;

            // ── btnBack ───────────────────────────────────────────
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(27, 64, 121);
            btnBack.ForeColor = Color.FromArgb(27, 64, 121);
            btnBack.Location = new Point(30, 487);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(260, 35);
            btnBack.TabIndex = 7;
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
            pnlList.Controls.Add(lbRoles);

            // ── lblListTitle ──────────────────────────────────────
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblListTitle.Location = new Point(20, 18);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Списък с роли";

            // ── lbRoles ───────────────────────────────────────────
            lbRoles.BorderStyle = BorderStyle.None;
            lbRoles.Font = new Font("Segoe UI", 10F);
            lbRoles.FormattingEnabled = true;
            lbRoles.ItemHeight = 28;
            lbRoles.Location = new Point(20, 50);
            lbRoles.Name = "lbRoles";
            lbRoles.Size = new Size(560, 475);
            lbRoles.TabIndex = 1;
            lbRoles.SelectedIndexChanged += lbRoles_SelectedIndexChanged;

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
        private Label lblName;
        private TextBox txtbName;
        private ListBox lbRoles;
        private Button btnAddRole;
        private Button btnUpdate;
        private Button btnRemoveUser;
        private Button btnBack;
    }
}