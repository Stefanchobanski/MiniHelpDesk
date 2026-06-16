namespace App.Forms
{
    partial class TicketAdminForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlGrid = new Panel();
            dgvTikets = new DataGridView();
            pnlActions = new Panel();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlGrid.SuspendLayout();
            pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTikets).BeginInit();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 660);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TicketAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Тикети";
            Font = new Font("Segoe UI", 9F);
            Controls.Add(pnlHeader);
            Controls.Add(pnlGrid);
            Controls.Add(pnlActions);
            Load += TicketAdminForm_Load;

            // ── pnlHeader ─────────────────────────────────────────
            pnlHeader.BackColor = Color.White;
            pnlHeader.Location = new Point(20, 15);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1080, 70);
            pnlHeader.TabIndex = 0;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);

            // ── lblTitle ──────────────────────────────────────────
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(0, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Управление на тикети";

            // ── lblSubtitle ───────────────────────────────────────
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(3, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Преглед и редакция на всички тикети в системата";

            // ── pnlGrid ───────────────────────────────────────────
            pnlGrid.BackColor = Color.FromArgb(245, 248, 252);
            pnlGrid.Location = new Point(20, 100);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(1080, 480);
            pnlGrid.TabIndex = 1;
            pnlGrid.Padding = new Padding(10);
            pnlGrid.Controls.Add(dgvTikets);

            // ── dgvTikets ─────────────────────────────────────────
            dgvTikets.BackgroundColor = Color.FromArgb(245, 248, 252);
            dgvTikets.BorderStyle = BorderStyle.None;
            dgvTikets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTikets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTikets.EnableHeadersVisualStyles = false;
            dgvTikets.GridColor = Color.FromArgb(220, 230, 240);
            dgvTikets.RowHeadersVisible = false;
            dgvTikets.AllowUserToAddRows = false;
            dgvTikets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTikets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTikets.Location = new Point(10, 10);
            dgvTikets.Name = "dgvTikets";
            dgvTikets.Size = new Size(1060, 460);
            dgvTikets.TabIndex = 0;
            // Header style
            dgvTikets.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 64, 121);
            dgvTikets.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTikets.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvTikets.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgvTikets.ColumnHeadersHeight = 36;
            dgvTikets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // Row style
            dgvTikets.DefaultCellStyle.BackColor = Color.White;
            dgvTikets.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dgvTikets.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 225, 245);
            dgvTikets.DefaultCellStyle.SelectionForeColor = Color.FromArgb(27, 64, 121);
            dgvTikets.DefaultCellStyle.Padding = new Padding(4);
            dgvTikets.RowTemplate.Height = 30;
            // Alternating row style
            dgvTikets.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252);

            // ── pnlActions ────────────────────────────────────────
            pnlActions.BackColor = Color.White;
            pnlActions.Location = new Point(20, 595);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1080, 50);
            pnlActions.TabIndex = 2;
            pnlActions.Controls.Add(btnUpdate);
            pnlActions.Controls.Add(btnRemove);
            pnlActions.Controls.Add(btnBack);

            // ── btnUpdate ─────────────────────────────────────────
            btnUpdate.BackColor = Color.FromArgb(27, 64, 121);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(0, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 38);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Запази промените";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            // ── btnRemove ─────────────────────────────────────────
            btnRemove.BackColor = Color.FromArgb(180, 50, 50);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(175, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(160, 38);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Премахни тикет";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;

            // ── btnBack ───────────────────────────────────────────
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(27, 64, 121);
            btnBack.ForeColor = Color.FromArgb(27, 64, 121);
            btnBack.Location = new Point(350, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 38);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlGrid.ResumeLayout(false);
            pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTikets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlGrid;
        private Panel pnlActions;
        private Label lblTitle;
        private Label lblSubtitle;
        private DataGridView dgvTikets;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnBack;
    }
}