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
    public AdminForm(IAdminService adminService)
    {
        InitializeComponent();
        _adminService = adminService;
    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
        this.Hide();

        UserForm userForm = new UserForm(_adminService, this);
        userForm.FormClosed += (s, args) => this.Close();
        userForm.Show();
    }

}
