namespace App.Forms
{
    partial class TicketView
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
            pnlInfo = new Panel();
            lblFormTitle = new Label();
            lblTicketNumber = new Label();
            lblStatusBadge = new Label();
            lblPriorityBadge = new Label();
            lblEmailTitle = new Label();
            lblEmailValue = new Label();
            lblCategoryTitle = new Label();
            lblCategoryValue = new Label();
            lblTechnicianTitle = new Label();
            lblTechnicianValue = new Label();
            lblCreatedTitle = new Label();
            lblCreatedValue = new Label();
            lblDescriptionTitle = new Label();
            txtDescription = new TextBox();
            btnBack = new Button();
            pnlComments = new Panel();
            lblCommentsTitle = new Label();
            lstComments = new ListBox();
            pnlInfo.SuspendLayout();
            pnlComments.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.White;
            pnlInfo.Controls.Add(lblFormTitle);
            pnlInfo.Controls.Add(lblTicketNumber);
            pnlInfo.Controls.Add(lblStatusBadge);
            pnlInfo.Controls.Add(lblPriorityBadge);
            pnlInfo.Controls.Add(lblEmailTitle);
            pnlInfo.Controls.Add(lblEmailValue);
            pnlInfo.Controls.Add(lblCategoryTitle);
            pnlInfo.Controls.Add(lblCategoryValue);
            pnlInfo.Controls.Add(lblTechnicianTitle);
            pnlInfo.Controls.Add(lblTechnicianValue);
            pnlInfo.Controls.Add(lblCreatedTitle);
            pnlInfo.Controls.Add(lblCreatedValue);
            pnlInfo.Controls.Add(lblDescriptionTitle);
            pnlInfo.Controls.Add(txtDescription);
            pnlInfo.Controls.Add(btnBack);
            pnlInfo.Location = new Point(20, 20);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(380, 660);
            pnlInfo.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(78, 32);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Тикет";
            // 
            // lblTicketNumber
            // 
            lblTicketNumber.AutoSize = true;
            lblTicketNumber.ForeColor = Color.FromArgb(77, 124, 138);
            lblTicketNumber.Location = new Point(3, 42);
            lblTicketNumber.Name = "lblTicketNumber";
            lblTicketNumber.Size = new Size(160, 15);
            lblTicketNumber.TabIndex = 1;
            lblTicketNumber.Text = "#0000 — Заглавие на тикета";
            // 
            // lblStatusBadge
            // 
            lblStatusBadge.BackColor = Color.FromArgb(27, 64, 121);
            lblStatusBadge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusBadge.ForeColor = Color.White;
            lblStatusBadge.Location = new Point(0, 75);
            lblStatusBadge.Name = "lblStatusBadge";
            lblStatusBadge.Size = new Size(140, 28);
            lblStatusBadge.TabIndex = 2;
            lblStatusBadge.Text = "Статус";
            lblStatusBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPriorityBadge
            // 
            lblPriorityBadge.BackColor = Color.FromArgb(77, 124, 138);
            lblPriorityBadge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPriorityBadge.ForeColor = Color.White;
            lblPriorityBadge.Location = new Point(150, 75);
            lblPriorityBadge.Name = "lblPriorityBadge";
            lblPriorityBadge.Size = new Size(140, 28);
            lblPriorityBadge.TabIndex = 3;
            lblPriorityBadge.Text = "Приоритет";
            lblPriorityBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.ForeColor = Color.FromArgb(150, 150, 150);
            lblEmailTitle.Location = new Point(3, 125);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(114, 15);
            lblEmailTitle.TabIndex = 4;
            lblEmailTitle.Text = "Имейл на подателя";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmailValue.ForeColor = Color.FromArgb(40, 40, 40);
            lblEmailValue.Location = new Point(3, 145);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(21, 17);
            lblEmailValue.TabIndex = 5;
            lblEmailValue.Text = "—";
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.ForeColor = Color.FromArgb(150, 150, 150);
            lblCategoryTitle.Location = new Point(3, 180);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(63, 15);
            lblCategoryTitle.TabIndex = 6;
            lblCategoryTitle.Text = "Категория";
            // 
            // lblCategoryValue
            // 
            lblCategoryValue.AutoSize = true;
            lblCategoryValue.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategoryValue.ForeColor = Color.FromArgb(40, 40, 40);
            lblCategoryValue.Location = new Point(3, 200);
            lblCategoryValue.Name = "lblCategoryValue";
            lblCategoryValue.Size = new Size(21, 17);
            lblCategoryValue.TabIndex = 7;
            lblCategoryValue.Text = "—";
            // 
            // lblTechnicianTitle
            // 
            lblTechnicianTitle.AutoSize = true;
            lblTechnicianTitle.ForeColor = Color.FromArgb(150, 150, 150);
            lblTechnicianTitle.Location = new Point(3, 235);
            lblTechnicianTitle.Name = "lblTechnicianTitle";
            lblTechnicianTitle.Size = new Size(99, 15);
            lblTechnicianTitle.TabIndex = 8;
            lblTechnicianTitle.Text = "Назначен техник";
            // 
            // lblTechnicianValue
            // 
            lblTechnicianValue.AutoSize = true;
            lblTechnicianValue.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTechnicianValue.ForeColor = Color.FromArgb(40, 40, 40);
            lblTechnicianValue.Location = new Point(3, 255);
            lblTechnicianValue.Name = "lblTechnicianValue";
            lblTechnicianValue.Size = new Size(84, 17);
            lblTechnicianValue.TabIndex = 9;
            lblTechnicianValue.Text = "Неназначен";
            // 
            // lblCreatedTitle
            // 
            lblCreatedTitle.AutoSize = true;
            lblCreatedTitle.ForeColor = Color.FromArgb(150, 150, 150);
            lblCreatedTitle.Location = new Point(3, 290);
            lblCreatedTitle.Name = "lblCreatedTitle";
            lblCreatedTitle.Size = new Size(74, 15);
            lblCreatedTitle.TabIndex = 10;
            lblCreatedTitle.Text = "Създаден на";
            // 
            // lblCreatedValue
            // 
            lblCreatedValue.AutoSize = true;
            lblCreatedValue.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCreatedValue.ForeColor = Color.FromArgb(40, 40, 40);
            lblCreatedValue.Location = new Point(3, 310);
            lblCreatedValue.Name = "lblCreatedValue";
            lblCreatedValue.Size = new Size(21, 17);
            lblCreatedValue.TabIndex = 11;
            lblCreatedValue.Text = "—";
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescriptionTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblDescriptionTitle.Location = new Point(0, 350);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(79, 19);
            lblDescriptionTitle.TabIndex = 12;
            lblDescriptionTitle.Text = "Описание";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(245, 248, 252);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(0, 375);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(380, 200);
            txtDescription.TabIndex = 13;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(27, 64, 121);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.FromArgb(27, 64, 121);
            btnBack.Location = new Point(0, 615);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(380, 38);
            btnBack.TabIndex = 14;
            btnBack.Text = "← Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pnlComments
            // 
            pnlComments.BackColor = Color.FromArgb(245, 248, 252);
            pnlComments.Controls.Add(lblCommentsTitle);
            pnlComments.Controls.Add(lstComments);
            pnlComments.Location = new Point(420, 20);
            pnlComments.Name = "pnlComments";
            pnlComments.Size = new Size(660, 660);
            pnlComments.TabIndex = 1;
            // 
            // lblCommentsTitle
            // 
            lblCommentsTitle.AutoSize = true;
            lblCommentsTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCommentsTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblCommentsTitle.Location = new Point(20, 18);
            lblCommentsTitle.Name = "lblCommentsTitle";
            lblCommentsTitle.Size = new Size(120, 20);
            lblCommentsTitle.TabIndex = 0;
            lblCommentsTitle.Text = "💬  Коментари";
            // 
            // lstComments
            // 
            lstComments.BorderStyle = BorderStyle.None;
            lstComments.Font = new Font("Segoe UI", 9.5F);
            lstComments.FormattingEnabled = true;
            lstComments.Location = new Point(20, 50);
            lstComments.Name = "lstComments";
            lstComments.Size = new Size(620, 578);
            lstComments.TabIndex = 1;
            // 
            // TicketView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlInfo);
            Controls.Add(pnlComments);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TicketView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Преглед на тикет";
            Load += TicketView_Load;
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            pnlComments.ResumeLayout(false);
            pnlComments.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInfo;
        private Label lblFormTitle;
        private Label lblTicketNumber;
        private Label lblStatusBadge;
        private Label lblPriorityBadge;
        private Label lblEmailTitle;
        private Label lblEmailValue;
        private Label lblCategoryTitle;
        private Label lblCategoryValue;
        private Label lblTechnicianTitle;
        private Label lblTechnicianValue;
        private Label lblCreatedTitle;
        private Label lblCreatedValue;
        private Label lblDescriptionTitle;
        private TextBox txtDescription;
        private Button btnBack;
        private Panel pnlComments;
        private Label lblCommentsTitle;
        private ListBox lstComments;
    }
}