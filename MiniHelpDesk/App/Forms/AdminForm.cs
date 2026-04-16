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
    public AdminForm(IAdminService adminService, IRoleService roleService)
    {
        InitializeComponent();
        _adminService = adminService;
        _roleService = roleService;
    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
        this.Hide();

        UserForm userForm = new UserForm(_adminService, this, _roleService);
        userForm.FormClosed += (s, args) => this.Show();
        userForm.Show();
    }

}
