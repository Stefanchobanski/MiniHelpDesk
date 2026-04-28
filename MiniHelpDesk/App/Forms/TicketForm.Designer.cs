namespace App.Forms
{
    partial class TicketForm
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
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F);
            lblTitle.Location = new Point(98, 105);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(48, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(179, 105);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(209, 23);
            txtTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F);
            lblDescription.Location = new Point(61, 171);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(112, 25);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(179, 171);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(399, 197);
            txtDescription.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEmail.Location = new Point(92, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 21);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSend.Location = new Point(269, 391);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(184, 37);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 450);
            Controls.Add(btnSend);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Name = "TicketForm";
            Text = "TicketForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSend;
    }
}