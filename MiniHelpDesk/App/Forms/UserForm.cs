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
    private readonly IRoleService _roleService;
    private readonly TicketService _ticketService;
    public UserForm(IAdminService adminService, AdminForm adminForm, IRoleService roleService, TicketService ticketService)
    {
        InitializeComponent();
        _adminService = adminService;
        _adminForm = adminForm;
        _roleService = roleService;
        _ticketService = ticketService;
    }

    private int _selectedIndex = -1;

    private async void UserForm_Load(object sender, EventArgs e)
    {
        try
        {
            var roles = await _roleService.GetRolesAsync();
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Name";
            cmbRoles.ValueMember = "RoleID";

            var users = await _adminService.GetUsersWithRole();
            lbUsers.DataSource = users;
            lbUsers.DisplayMember = "Display";
            lbUsers.ValueMember = "UserId";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            _selectedIndex = lbUsers.SelectedIndex;
            FormHelper.CheckSelectedIndex(_selectedIndex);

            txtbUsername.Enabled = true;
            txtbEmail.Enabled = true;

            var user = lbUsers.SelectedItem as UserRoleDTO;

            txtbUsername.Text = user.UserName;
            txtbEmail.Text = user.Email;
            cmbRoles.SelectedValue = user.RoleId;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnRemoveUser_Click(object sender, EventArgs e)
    {
        try
        {
            FormHelper.CheckSelectedIndex(_selectedIndex);

            await _adminService.RemoveAddUserWithTables((int)lbUsers.SelectedValue);
            lbUsers.DataSource = await _adminService.GetUsersWithRole();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            FormHelper.CheckSelectedIndex(_selectedIndex);

            string username = txtbUsername.Text;
            string email = txtbEmail.Text;
            int roleId = (int)cmbRoles.SelectedValue;

            await _adminService.UpdateUsers((int)lbUsers.SelectedValue, username, email, roleId);
            lbUsers.DataSource = await _adminService.GetUsersWithRole();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        try
        {
            _adminForm.Show();
            _adminForm.FormClosed += (s, args) => this.Close();
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Възникна грешка!");
        }
    }

    private void btnShowTickets_Click(object sender, EventArgs e)
    {
        try
        {
            FormHelper.CheckSelectedIndex(_selectedIndex);

            this.Hide();

            TicketAdminForm ticketForm = new TicketAdminForm(this, _ticketService, (int)lbUsers.SelectedValue);
            ticketForm.FormClosed += (s, args) => this.Show();
            ticketForm.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Възникна грешка!");
        }
    }
}
