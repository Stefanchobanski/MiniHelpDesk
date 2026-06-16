namespace App.Forms
{
    partial class CategoriesForm
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
            btnAddCategory = new Button();
            btnUpdateCategory = new Button();
            btnRemoveCategory = new Button();
            btnBack = new Button();
            pnlList = new Panel();
            lblListTitle = new Label();
            lbCategories = new ListBox();

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
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Категории";
            Font = new Font("Segoe UI", 9F);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlList);
            Load += CategoriesForm_Load;

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
            pnlSidebar.Controls.Add(btnAddCategory);
            pnlSidebar.Controls.Add(btnUpdateCategory);
            pnlSidebar.Controls.Add(btnRemoveCategory);
            pnlSidebar.Controls.Add(btnBack);

            // ── lblTitle ──────────────────────────────────────────
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(30, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Категории";

            // ── lblSubtitle ───────────────────────────────────────
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(32, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Управление на категории";

            // ── lblName ───────────────────────────────────────────
            lblName.Location = new Point(30, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(260, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Наименование";
            lblName.ForeColor = Color.FromArgb(27, 64, 121);

            // ── txtbName ──────────────────────────────────────────
            txtbName.Location = new Point(30, 138);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(260, 23);
            txtbName.TabIndex = 3;
            txtbName.BorderStyle = BorderStyle.FixedSingle;

            // ── btnAddCategory ────────────────────────────────────
            btnAddCategory.BackColor = Color.FromArgb(77, 124, 138);
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Location = new Point(30, 185);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(260, 38);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "➕  Добави категория";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;

            // ── btnUpdateCategory ─────────────────────────────────
            btnUpdateCategory.BackColor = Color.FromArgb(27, 64, 121);
            btnUpdateCategory.FlatStyle = FlatStyle.Flat;
            btnUpdateCategory.FlatAppearance.BorderSize = 0;
            btnUpdateCategory.ForeColor = Color.White;
            btnUpdateCategory.Location = new Point(30, 238);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(260, 38);
            btnUpdateCategory.TabIndex = 5;
            btnUpdateCategory.Text = "💾  Запази промените";
            btnUpdateCategory.UseVisualStyleBackColor = false;
            btnUpdateCategory.Click += btnUpdateCategory_Click;

            // ── btnRemoveCategory ─────────────────────────────────
            btnRemoveCategory.BackColor = Color.FromArgb(180, 50, 50);
            btnRemoveCategory.FlatStyle = FlatStyle.Flat;
            btnRemoveCategory.FlatAppearance.BorderSize = 0;
            btnRemoveCategory.ForeColor = Color.White;
            btnRemoveCategory.Location = new Point(30, 291);
            btnRemoveCategory.Name = "btnRemoveCategory";
            btnRemoveCategory.Size = new Size(260, 38);
            btnRemoveCategory.TabIndex = 6;
            btnRemoveCategory.Text = "🗑️  Премахни категория";
            btnRemoveCategory.UseVisualStyleBackColor = false;
            btnRemoveCategory.Click += btnRemoveCategory_Click;

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
            pnlList.Controls.Add(lbCategories);

            // ── lblListTitle ──────────────────────────────────────
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblListTitle.Location = new Point(20, 18);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Списък с категории";

            // ── lbCategories ──────────────────────────────────────
            lbCategories.BorderStyle = BorderStyle.None;
            lbCategories.Font = new Font("Segoe UI", 10F);
            lbCategories.FormattingEnabled = true;
            lbCategories.ItemHeight = 28;
            lbCategories.Location = new Point(20, 50);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(560, 475);
            lbCategories.TabIndex = 1;
            lbCategories.SelectedIndexChanged += lbCategories_SelectedIndexChanged;

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
        private ListBox lbCategories;
        private Button btnAddCategory;
        private Button btnUpdateCategory;
        private Button btnRemoveCategory;
        private Button btnBack;
    }
}