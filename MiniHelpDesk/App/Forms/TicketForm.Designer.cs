namespace App.Forms
{
    partial class TicketForm
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
            pnlBody = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblFormTitle = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSend = new Button();

            pnlBody.SuspendLayout();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 640);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TicketForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk - Нов тикет";
            Font = new Font("Segoe UI", 9F);
            Controls.Add(pnlBody);

            // ── pnlBody ───────────────────────────────────────────
            pnlBody.BackColor = Color.White;
            pnlBody.Location = new Point(35, 20);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(450, 600);
            pnlBody.TabIndex = 0;
            pnlBody.Controls.Add(lblTitle);
            pnlBody.Controls.Add(lblSubtitle);
            pnlBody.Controls.Add(lblEmail);
            pnlBody.Controls.Add(txtEmail);
            pnlBody.Controls.Add(lblFormTitle);
            pnlBody.Controls.Add(txtTitle);
            pnlBody.Controls.Add(lblDescription);
            pnlBody.Controls.Add(txtDescription);
            pnlBody.Controls.Add(btnSend);

            // ── lblTitle ──────────────────────────────────────────
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(80, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Нов тикет";

            // ── lblSubtitle ───────────────────────────────────────
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(84, 44);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Опишете своя проблем";

            // ── lblEmail ──────────────────────────────────────────
            lblEmail.Location = new Point(0, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(150, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Имейл";

            // ── txtEmail ──────────────────────────────────────────
            txtEmail.Location = new Point(0, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(450, 23);
            txtEmail.TabIndex = 3;

            // ── lblFormTitle ──────────────────────────────────────
            lblFormTitle.Location = new Point(0, 155);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(150, 20);
            lblFormTitle.TabIndex = 4;
            lblFormTitle.Text = "Заглавие";

            // ── txtTitle ──────────────────────────────────────────
            txtTitle.Location = new Point(0, 178);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(450, 23);
            txtTitle.TabIndex = 5;

            // ── lblDescription ────────────────────────────────────
            lblDescription.Location = new Point(0, 220);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(150, 20);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Описание";

            // ── txtDescription ────────────────────────────────────
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(0, 243);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(450, 260);
            txtDescription.TabIndex = 7;

            // ── btnSend ───────────────────────────────────────────
            btnSend.BackColor = Color.FromArgb(27, 64, 121);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(0, 525);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(450, 45);
            btnSend.TabIndex = 8;
            btnSend.Text = "Изпрати тикет";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;

            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBody;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblFormTitle;
        private TextBox txtTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnSend;
    }
}