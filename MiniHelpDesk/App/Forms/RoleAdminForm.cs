using App.Models.DTOs;
using App.Services;
using App.Services.interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
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
    public partial class RoleAdminForm : Form
    {
        private AdminForm _adminForm;
        private IRoleService _roleService;
        public RoleAdminForm(AdminForm adminForm, IRoleService roleService)
        {
            InitializeComponent();
            _adminForm = adminForm;
            _roleService = roleService;
        }

        private int _index = -1;

        private async void RoleAdminForm_Load(object sender, EventArgs e)
        {
            lbRoles.DataSource = await _roleService.GetRolesAsync();
            lbRoles.DisplayMember = "Display";
            lbRoles.ValueMember = "RoleId";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _adminForm.Show();
            _adminForm.FormClosed += (s, args) => this.Close();
            this.Close();
        }

        private async void btnRemoveUser_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.CheckSelectedIndex(_index);

                await _roleService.RemoveRole((int)lbRoles.SelectedValue);

                lbRoles.DataSource = await _roleService.GetRolesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void lbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _index = lbRoles.SelectedIndex;

                txtbName.Enabled = true;

                var role = lbRoles.SelectedItem as RoleDTO;

                txtbName.Text = role.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtbName.Text;
                await _roleService.AddRole(name);
                lbRoles.DataSource = await _roleService.GetRolesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            { 
                FormHelper.CheckSelectedIndex(_index);

                string newName = txtbName.Text;

                await _roleService.UpdateRole((int)lbRoles.SelectedValue, newName);
                lbRoles.DataSource = await _roleService.GetRolesAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
