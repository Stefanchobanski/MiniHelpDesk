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
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTikets).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(26, 536);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 59);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvTikets
            // 
            dgvTikets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTikets.Location = new Point(14, 16);
            dgvTikets.Margin = new Padding(3, 4, 3, 4);
            dgvTikets.Name = "dgvTikets";
            dgvTikets.RowHeadersWidth = 51;
            dgvTikets.Size = new Size(1093, 377);
            dgvTikets.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(26, 447);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 59);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(197, 447);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(136, 59);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // TicketAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 653);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(dgvTikets);
            Controls.Add(btnBack);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnRemove;
    }
}