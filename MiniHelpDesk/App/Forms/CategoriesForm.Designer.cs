namespace App.Forms
{
    partial class CategoriesForm
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
            btnUpdateCategory = new Button();
            btnRemoveCategory = new Button();
            txtbName = new TextBox();
            lblName = new Label();
            lbCategories = new ListBox();
            btnAddCategory = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(79, 500);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 44);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(79, 433);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(119, 44);
            btnUpdateCategory.TabIndex = 19;
            btnUpdateCategory.Text = "Update";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCategory
            // 
            btnRemoveCategory.Location = new Point(79, 359);
            btnRemoveCategory.Name = "btnRemoveCategory";
            btnRemoveCategory.Size = new Size(119, 54);
            btnRemoveCategory.TabIndex = 18;
            btnRemoveCategory.Text = "Remove";
            btnRemoveCategory.UseVisualStyleBackColor = true;
            btnRemoveCategory.Click += btnRemoveCategory_Click;
            // 
            // txtbName
            // 
            txtbName.Location = new Point(67, 166);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(146, 29);
            txtbName.TabIndex = 16;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(114, 131);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 21);
            lblName.TabIndex = 12;
            lblName.Text = "Name";
            // 
            // lbCategories
            // 
            lbCategories.FormattingEnabled = true;
            lbCategories.Location = new Point(403, 72);
            lbCategories.Margin = new Padding(4);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(546, 487);
            lbCategories.TabIndex = 11;
            lbCategories.SelectedIndexChanged += lbCategories_SelectedIndexChanged;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(79, 295);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(119, 44);
            btnAddCategory.TabIndex = 21;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(btnAddCategory);
            Controls.Add(btnBack);
            Controls.Add(btnUpdateCategory);
            Controls.Add(btnRemoveCategory);
            Controls.Add(txtbName);
            Controls.Add(lblName);
            Controls.Add(lbCategories);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CategoriesForm";
            Text = "CategoriesForm";
            Load += CategoriesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnUpdateCategory;
        private Button btnRemoveCategory;
        private TextBox txtbName;
        private Label lblName;
        private ListBox lbCategories;
        private Button btnAddCategory;
    }
}