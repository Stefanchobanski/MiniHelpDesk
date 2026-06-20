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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlGrid = new Panel();
            dgvTikets = new DataGridView();
            pnlActions = new Panel();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnBack = new Button();
            btnComments = new Button();
            pnlHeader.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTikets).BeginInit();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Location = new Point(20, 15);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1080, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(0, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Управление на тикети";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(3, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(282, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Преглед и редакция на всички тикети в системата";
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 248, 252);
            pnlGrid.Controls.Add(dgvTikets);
            pnlGrid.Location = new Point(20, 100);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(10);
            pnlGrid.Size = new Size(1080, 480);
            pnlGrid.TabIndex = 1;
            // 
            // dgvTikets
            // 
            dgvTikets.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 248, 252);
            dgvTikets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTikets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTikets.BackgroundColor = Color.FromArgb(245, 248, 252);
            dgvTikets.BorderStyle = BorderStyle.None;
            dgvTikets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTikets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(27, 64, 121);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTikets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTikets.ColumnHeadersHeight = 36;
            dgvTikets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle6.Padding = new Padding(4);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(210, 225, 245);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(27, 64, 121);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTikets.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTikets.EnableHeadersVisualStyles = false;
            dgvTikets.GridColor = Color.FromArgb(220, 230, 240);
            dgvTikets.Location = new Point(10, 10);
            dgvTikets.Name = "dgvTikets";
            dgvTikets.RowHeadersVisible = false;
            dgvTikets.RowTemplate.Height = 30;
            dgvTikets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTikets.Size = new Size(1060, 460);
            dgvTikets.TabIndex = 0;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.White;
            pnlActions.Controls.Add(btnComments);
            pnlActions.Controls.Add(btnUpdate);
            pnlActions.Controls.Add(btnRemove);
            pnlActions.Controls.Add(btnBack);
            pnlActions.Location = new Point(20, 595);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1080, 50);
            pnlActions.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(27, 64, 121);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(0, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 38);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Запази промените";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(180, 50, 50);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(175, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(160, 38);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Премахни тикет";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(27, 64, 121);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.FromArgb(27, 64, 121);
            btnBack.Location = new Point(543, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 38);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnComments
            // 
            btnComments.BackColor = Color.Sienna;
            btnComments.FlatAppearance.BorderSize = 0;
            btnComments.FlatStyle = FlatStyle.Flat;
            btnComments.ForeColor = Color.White;
            btnComments.Location = new Point(357, 5);
            btnComments.Name = "btnComments";
            btnComments.Size = new Size(160, 38);
            btnComments.TabIndex = 3;
            btnComments.Text = "Преглед на коментари";
            btnComments.UseVisualStyleBackColor = false;
            btnComments.Click += btnComments_Click;
            // 
            // TicketAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 660);
            Controls.Add(pnlHeader);
            Controls.Add(pnlGrid);
            Controls.Add(pnlActions);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TicketAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Тикети";
            Load += TicketAdminForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTikets).EndInit();
            pnlActions.ResumeLayout(false);
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
        private Button btnComments;
    }
}