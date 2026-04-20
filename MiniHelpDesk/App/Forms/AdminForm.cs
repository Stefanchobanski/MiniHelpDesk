using App.Services;
using App.Services.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms;

public partial class AdminForm : Form
{
    private readonly IAdminService _adminService;
    private readonly IRoleService _roleService;
    private readonly CategoryService _categoryService;
    public AdminForm(IAdminService adminService, IRoleService roleService, CategoryService categoryService)
    {
        InitializeComponent();
        _adminService = adminService;
        _roleService = roleService;
        _categoryService = categoryService;
    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
        this.Hide();

        UserForm userForm = new UserForm(_adminService, this, _roleService);
        userForm.FormClosed += (s, args) => this.Show();
        userForm.Show();
    }

    private void btnCategories_Click(object sender, EventArgs e)
    {
        this.Hide();

        CategoriesForm categoryForm = new CategoriesForm(this, _categoryService);
        categoryForm.FormClosed += (s, args) => this.Show();
        categoryForm.Show();
    }
}
