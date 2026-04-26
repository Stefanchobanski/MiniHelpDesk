using App.Models;
using App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class CategoriesForm : Form
    {
        private readonly AdminForm _adminForm;
        private readonly CategoryService _categoryService;

        private int _index = -1;

        public CategoriesForm(AdminForm adminForm, CategoryService categoryService)
        {
            InitializeComponent();
            _adminForm = adminForm;
            _categoryService = categoryService;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _adminForm.Show();
            _adminForm.FormClosed += (s, args) => this.Close();
            this.Close();
        }

        private async void CategoriesForm_Load(object sender, EventArgs e)
        {
            lbCategories.DataSource = await _categoryService.GetCategoriesAsync();
            lbCategories.DisplayMember = "Name";
        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _index = lbCategories.SelectedIndex;

                FormHelper.CheckSelectedIndex(_index);

                var role = lbCategories.SelectedItem as Category;

                txtbName.Text = role.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtbName.Text;

                await _categoryService.AddCategory(name);
                lbCategories.DataSource = await _categoryService.GetCategoriesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        private async void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.CheckSelectedIndex(_index);

                var category = lbCategories.SelectedItem as Category;

                await _categoryService.RemoveCategory(category.CategoryId);

                lbCategories.DataSource = await _categoryService.GetCategoriesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }
    }
}
