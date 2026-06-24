namespace App.Forms
{
    partial class AdminForm
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
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            btnUsers = new Button();
            btnCategories = new Button();
            btnRoles = new Button();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.Controls.Add(pictureBox1);
            pnlBody.Controls.Add(lblTitle);
            pnlBody.Controls.Add(lblSubtitle);
            pnlBody.Controls.Add(lblWelcome);
            pnlBody.Controls.Add(btnUsers);
            pnlBody.Controls.Add(btnCategories);
            pnlBody.Controls.Add(btnRoles);
            pnlBody.Location = new Point(35, 20);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(350, 415);
            pnlBody.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logopgtk;
            pictureBox1.Location = new Point(131, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 64, 121);
            lblTitle.Location = new Point(70, 117);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Админ панел";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(77, 124, 138);
            lblSubtitle.Location = new Point(88, 158);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(166, 15);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Управление на MiniHelpDesk";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblWelcome.ForeColor = Color.FromArgb(100, 100, 100);
            lblWelcome.Location = new Point(30, 195);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(190, 15);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Изберете раздел за управление:";
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(27, 64, 121);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(30, 230);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(290, 45);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "👤  Потребители";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(27, 64, 121);
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(30, 290);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(290, 45);
            btnCategories.TabIndex = 5;
            btnCategories.Text = "📂  Категории";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnRoles
            // 
            btnRoles.BackColor = Color.FromArgb(27, 64, 121);
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.ForeColor = Color.White;
            btnRoles.Location = new Point(30, 350);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(290, 45);
            btnRoles.TabIndex = 6;
            btnRoles.Text = "🔑  Роли";
            btnRoles.UseVisualStyleBackColor = false;
            btnRoles.Click += btnRoles_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 452);
            Controls.Add(pnlBody);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniHelpDesk – Админ панел";
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBody;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblWelcome;
        private Button btnUsers;
        private Button btnCategories;
        private Button btnRoles;
    }
}