namespace App.Forms
{
    partial class TicketAdminForm
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
            btnBack = new Button();
            dgvTikets = new DataGridView();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTikets).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(23, 402);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 44);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvTikets
            // 
            dgvTikets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTikets.Location = new Point(12, 12);
            dgvTikets.Name = "dgvTikets";
            dgvTikets.Size = new Size(956, 283);
            dgvTikets.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(23, 335);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 44);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // TicketAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 490);
            Controls.Add(btnUpdate);
            Controls.Add(dgvTikets);
            Controls.Add(btnBack);
            Name = "TicketAdminForm";
            Text = "TicketAdminForm";
            Load += TicketAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTikets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private DataGridView dgvTikets;
        private Button btnUpdate;
    }
}