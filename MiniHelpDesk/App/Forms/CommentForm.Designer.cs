namespace App.Forms
{
    partial class CommentForm
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
            pnlComments = new Panel();
            lblCommentsTitle = new Label();
            lstComments = new ListBox();
            pnlNewComment = new Panel();
            lblNewComment = new Label();
            txtComment = new RichTextBox();
            lblCharCount = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlComments.SuspendLayout();
            pnlNewComment.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Location = new Point(20, 15);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1060, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(0, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Коментари";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(3, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(259, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Преглед и добавяне на коментари към тикета";
            // 
            // pnlComments
            // 
            pnlComments.BackColor = Color.FromArgb(245, 248, 252);
            pnlComments.Controls.Add(lblCommentsTitle);
            pnlComments.Controls.Add(lstComments);
            pnlComments.Location = new Point(20, 100);
            pnlComments.Name = "pnlComments";
            pnlComments.Size = new Size(1060, 360);
            pnlComments.TabIndex = 1;
            // 
            // lblCommentsTitle
            // 
            lblCommentsTitle.AutoSize = true;
            lblCommentsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCommentsTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblCommentsTitle.Location = new Point(15, 12);
            lblCommentsTitle.Name = "lblCommentsTitle";
            lblCommentsTitle.Size = new Size(212, 19);
            lblCommentsTitle.TabIndex = 0;
            lblCommentsTitle.Text = "📋  История на коментарите";
            // 
            // lstComments
            // 
            lstComments.BorderStyle = BorderStyle.None;
            lstComments.Font = new Font("Segoe UI", 10F);
            lstComments.FormattingEnabled = true;
            lstComments.Location = new Point(15, 40);
            lstComments.Name = "lstComments";
            lstComments.Size = new Size(1030, 306);
            lstComments.TabIndex = 1;
            // 
            // pnlNewComment
            // 
            pnlNewComment.BackColor = Color.White;
            pnlNewComment.Controls.Add(lblNewComment);
            pnlNewComment.Controls.Add(txtComment);
            pnlNewComment.Controls.Add(lblCharCount);
            pnlNewComment.Controls.Add(btnSubmit);
            pnlNewComment.Controls.Add(btnBack);
            pnlNewComment.Location = new Point(20, 475);
            pnlNewComment.Name = "pnlNewComment";
            pnlNewComment.Size = new Size(1060, 185);
            pnlNewComment.TabIndex = 2;
            // 
            // lblNewComment
            // 
            lblNewComment.AutoSize = true;
            lblNewComment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNewComment.ForeColor = Color.FromArgb(27, 64, 121);
            lblNewComment.Location = new Point(0, 5);
            lblNewComment.Name = "lblNewComment";
            lblNewComment.Size = new Size(137, 19);
            lblNewComment.TabIndex = 0;
            lblNewComment.Text = "✏️  Нов коментар";
            // 
            // txtComment
            // 
            txtComment.BorderStyle = BorderStyle.FixedSingle;
            txtComment.Font = new Font("Segoe UI", 10F);
            txtComment.Location = new Point(0, 30);
            txtComment.MaxLength = 500;
            txtComment.Name = "txtComment";
            txtComment.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtComment.Size = new Size(820, 90);
            txtComment.TabIndex = 1;
            txtComment.Text = "";
            txtComment.TextChanged += txtComment_TextChanged;
            // 
            // lblCharCount
            // 
            lblCharCount.AutoSize = true;
            lblCharCount.ForeColor = Color.FromArgb(150, 150, 150);
            lblCharCount.Location = new Point(0, 125);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(93, 15);
            lblCharCount.TabIndex = 2;
            lblCharCount.Text = "0 / 500 символа";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(27, 64, 121);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(835, 30);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(225, 45);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "💬  Добави коментар";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += this.btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(27, 64, 121);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.FromArgb(27, 64, 121);
            btnBack.Location = new Point(835, 90);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(225, 35);
            btnBack.TabIndex = 4;
            btnBack.Text = "← Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CommentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 680);
            Controls.Add(pnlHeader);
            Controls.Add(pnlComments);
            Controls.Add(pnlNewComment);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CommentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Коментари";
            Load += CommentForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlComments.ResumeLayout(false);
            pnlComments.PerformLayout();
            pnlNewComment.ResumeLayout(false);
            pnlNewComment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlComments;
        private Panel pnlNewComment;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblCommentsTitle;
        private Label lblNewComment;
        private Label lblCharCount;
        private ListBox lstComments;
        private RichTextBox txtComment;
        private Button btnSubmit;
        private Button btnBack;
    }
}