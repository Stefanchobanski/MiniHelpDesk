namespace App.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbAllTickets = new ListBox();
            lblUserName = new Label();
            lblTitle = new Label();
            txtInfo1 = new TextBox();
            txtInfo2 = new TextBox();
            txtInfo3 = new TextBox();
            btnUsers = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbAllTickets
            // 
            lbAllTickets.FormattingEnabled = true;
            lbAllTickets.Location = new Point(381, 96);
            lbAllTickets.Margin = new Padding(4);
            lbAllTickets.Name = "lbAllTickets";
            lbAllTickets.Size = new Size(579, 256);
            lbAllTickets.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(23, 27);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(44, 21);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Име:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(497, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(113, 21);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Admin панел";
            // 
            // txtInfo1
            // 
            txtInfo1.Location = new Point(23, 124);
            txtInfo1.Name = "txtInfo1";
            txtInfo1.Size = new Size(100, 29);
            txtInfo1.TabIndex = 4;
            // 
            // txtInfo2
            // 
            txtInfo2.Location = new Point(23, 174);
            txtInfo2.Name = "txtInfo2";
            txtInfo2.Size = new Size(100, 29);
            txtInfo2.TabIndex = 5;
            // 
            // txtInfo3
            // 
            txtInfo3.Location = new Point(23, 229);
            txtInfo3.Name = "txtInfo3";
            txtInfo3.Size = new Size(100, 29);
            txtInfo3.TabIndex = 6;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(44, 380);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(109, 41);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // button2
            // 
            button2.Location = new Point(44, 438);
            button2.Name = "button2";
            button2.Size = new Size(109, 41);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(button2);
            Controls.Add(btnUsers);
            Controls.Add(txtInfo3);
            Controls.Add(txtInfo2);
            Controls.Add(txtInfo1);
            Controls.Add(lblTitle);
            Controls.Add(lblUserName);
            Controls.Add(lbAllTickets);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAllTickets;
        private Label lblUserName;
        private Label lblTitle;
        private TextBox txtInfo1;
        private TextBox txtInfo2;
        private TextBox txtInfo3;
        private Button btnUsers;
        private Button button2;
    }
}