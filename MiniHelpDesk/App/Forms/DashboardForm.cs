using App.Models;
using App.Services;
using App.Services.interfaces;
using Microsoft.Extensions.Logging;
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
    public partial class DashboardForm : Form
    {

        private readonly ILogger<TicketAdminForm> _ticketAdminFormLogger;
        private readonly CommentService _commentService;
        private readonly ILogger<CommentForm> _commentFormLogger;

        private readonly TicketService _ticketService;
        private readonly IAdminService _adminService;
        private readonly int _userId;

        private readonly CategoryService _categoryService;

        public DashboardForm(TicketService ticketService, int idUser, IAdminService adminService, ILogger<TicketAdminForm> logger, CommentService commentService, ILogger<CommentForm> commentFormLogger, CategoryService categoryService)
        {
            InitializeComponent();
            _ticketService = ticketService;
            _userId = idUser;
            _adminService = adminService;
            _ticketAdminFormLogger = logger;
            _categoryService = categoryService;
            _commentService = commentService;
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            await LoadDashboard();
        }

        private async Task LoadDashboard()
        {
            lbxTickets.DataSource = await _ticketService.GetAllTicketFromRequester(_userId);
            lbxTickets.DisplayMember = "Title";
            lbxTickets.ValueMember = "TicketId";

            User? user = await _adminService.GetByIdUser(_userId);
            lblUsername.Text = user.Username;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                TicketForm ticketForm = new TicketForm(_ticketService, _userId);

                this.Hide();
                ticketForm.FormClosed += async (s, args) =>
                {
                    await LoadDashboard(); 
                    this.Show();
                };
                ticketForm.Show();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnViewTicket_Click(object sender, EventArgs e)
        {
            try
            {
                TicketView view = new TicketView(_ticketService, (int)lbxTickets.SelectedValue, _categoryService, _adminService, _commentService);

                this.Hide();
                view.FormClosed += (s, args) => this.Show();
                view.Show();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
