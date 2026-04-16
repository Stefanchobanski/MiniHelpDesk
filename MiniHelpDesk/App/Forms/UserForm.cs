using Accessibility;
using App.Models;
using App.Models.DTOs;
using App.Models.Enums;
using App.Services;
using App.Services.interfaces;
using Microsoft.VisualBasic.ApplicationServices;
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

public partial class UserForm : Form
{
    private readonly AdminForm _adminForm;
    private readonly IAdminService _adminService;
    public UserForm(IAdminService adminService, AdminForm adminForm)
    {
        InitializeComponent();
        _adminService = adminService;
        _adminForm = adminForm;
    }

    private int _selectedIndex = -1;

    private async void UserForm_Load(object sender, EventArgs e)
    {
        try
        {
            var roles = await _adminService.GetRolesAsync();
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Name";
            cmbRoles.ValueMember = "RoleID";

            var users = await _adminService.GetUsersWithRole();
            lbUsers.DataSource = users;
            lbUsers.DisplayMember = "Display";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message + " " + ex.StackTrace, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            _selectedIndex = lbUsers.SelectedIndex;
            CheckSelectedIndex(_selectedIndex);

            txtbUsername.Enabled = true;
            txtbEmail.Enabled = true;


            var user = lbUsers.SelectedItem as UserRoleDTO;

            txtbUsername.Text = user.UserName;
            txtbEmail.Text = user.Email;

            cmbRoles.SelectedValue = user.RoleId;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message + " " + ex.StackTrace, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CheckSelectedIndex(int index)
    {
        if (index == -1)
        {
            throw new IndexOutOfRangeException("Not selected item");
        }
    }

    private async void btnRemoveUser_Click(object sender, EventArgs e)
    {
        try
        {
            CheckSelectedIndex(_selectedIndex);

            var selectedUser = lbUsers.SelectedItem as UserRoleDTO;

            var tempUser = await _adminService.GetByIdUser(selectedUser.UserId);

            await _adminService.RemoveUser(tempUser.UserID);
            lbUsers.DataSource = await _adminService.GetUsersWithRole();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message + " " + ex.StackTrace, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            CheckSelectedIndex(_selectedIndex);

            var selectedUser = lbUsers.SelectedItem as UserRoleDTO;

            var tempUser = await _adminService.GetByIdUser(selectedUser.UserId);

            tempUser.Username = txtbUsername.Text;
            tempUser.Email = txtbEmail.Text;
            tempUser.RoleID = (int)cmbRoles.SelectedValue;

            await _adminService.UpdateUsers(tempUser);
            lbUsers.DataSource = await _adminService.GetUsersWithRole();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message + " " + ex.StackTrace, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        _adminForm.Show();
        _adminForm.FormClosed += (s, args) => this.Close();
        this.Close();
    }
}
