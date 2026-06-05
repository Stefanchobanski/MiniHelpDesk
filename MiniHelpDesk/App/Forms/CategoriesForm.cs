using App.Models;
using App.Models.DTOs;
using App.Services;
using Microsoft.Extensions.Logging;
using Serilog.Core;
using Serilog.Data;
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
        private readonly ILogger<CategoriesForm> _logger;

        private int _index = -1;

        public CategoriesForm(AdminForm adminForm, CategoryService categoryService, ILogger<CategoriesForm> logger)
        {
            InitializeComponent();
            _adminForm = adminForm;
            _categoryService = categoryService;
            _logger = logger;
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
            lbCategories.DisplayMember = "Info";
            lbCategories.ValueMember = "CategoryId";
        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _index = lbCategories.SelectedIndex;

                FormHelper.CheckSelectedIndex(_index);

                var category = lbCategories.SelectedItem as CategoryDTO;
                txtbName.Text = category.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError(ex.Message + " " + ex.StackTrace);
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
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError(ex.Message + " " + ex.StackTrace);
            }
        }

        private async void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.CheckSelectedIndex(_index);


                await _categoryService.RemoveCategory((int)lbCategories.SelectedValue);

                lbCategories.DataSource = await _categoryService.GetCategoriesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError(ex.Message + " " + ex.StackTrace);
            }
        }

        private async void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.CheckSelectedIndex(_index);

                string name = txtbName.Text;

                await _categoryService.UpdateCategory((int)lbCategories.SelectedValue, name);
                lbCategories.DataSource = await _categoryService.GetCategoriesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError(ex.Message + " " + ex.StackTrace);
            }
        }
    }
}
