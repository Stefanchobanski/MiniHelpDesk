using App.Models;
using App.Models.Enums;
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
using System.Xml.Linq;

namespace App.Forms
{
    public partial class TicketView : Form
    {
        private readonly int _ticketId;
        private readonly TicketService _ticketService;
        private readonly CategoryService _categoryService;
        private readonly IAdminService _adminService;
        private readonly CommentService _commentService;

        public TicketView(TicketService ticketService, int ticketId, CategoryService categoryService, IAdminService adminService, CommentService commentService)
        {
            InitializeComponent();
            _ticketService = ticketService;
            _ticketId = ticketId;
            _categoryService = categoryService;
            _adminService = adminService;
            _commentService = commentService;
        }

        private async void TicketView_Load(object sender, EventArgs e)
        {
            var ticket = await _ticketService.GetTicketById(_ticketId);

            lblTicketNumber.Text = $"#{ticket.TicketId:0000} — {ticket.Title}";

            lblStatusBadge.Text = ticket.Status.ToString();
            lblStatusBadge.BackColor = GetStatusColor(ParseStatus(ticket.Status));

            lblPriorityBadge.Text = ticket.Priority.ToString();
            lblPriorityBadge.BackColor = GetPriorityColor(ParsePriority(ticket.Priority));

            lblEmailValue.Text = ticket.Email;


            Category? category = null;
            if (ticket.CategoryId.HasValue)
            {
                category = await _categoryService.GetCategoryById(ticket.CategoryId.Value);
            }
            lblCategoryValue.Text = category?.Name ?? "Без категория";


            User? technician = null;
            if (ticket.TechnicianId.HasValue)
            {
                technician = await _adminService.GetByIdUser(ticket.TechnicianId.Value);
            }
            lblTechnicianValue.Text = technician?.Username ?? "Неназначен";


            lblCreatedValue.Text = ticket.CreatedAt.ToString("dd.MM.yyyy HH:mm");

            txtDescription.Text = ticket.Description;

            var comments = await _commentService.GetFromTicketAllComments(_ticketId);

            lstComments.Items.Clear();
            if (comments == null || comments.Count == 0)
            {
                lstComments.Items.Add("Няма коментари все още.");
                return;
            }

            foreach (var c in comments.OrderBy(c => c.CreatedDate))
            {
                lstComments.Items.Add($"[{c.CreatedDate:dd.MM.yyyy HH:mm}]  {c.Text}");
            }
        }

        private Status ParseStatus(string status)
        {
            return Enum.TryParse<Status>(status, true, out var result)
                ? result
                : Status.New;
        }

        private Priority ParsePriority(string priority)
        {
            return Enum.TryParse<Priority>(priority, true, out var result)
                ? result
                : Priority.Low;
        }

        private Color GetStatusColor(Status status)
        {
            return status switch
            {
                Status.New => Color.FromArgb(27, 64, 121),
                Status.InProgress => Color.FromArgb(200, 150, 30),
                Status.Closed => Color.FromArgb(90, 150, 90),
                _ => Color.Gray
            };
        }

        private Color GetPriorityColor(Priority priority)
        {
            return priority switch
            {
                Priority.Low => Color.FromArgb(90, 150, 90),
                Priority.Medium => Color.FromArgb(200, 150, 30),
                Priority.High => Color.FromArgb(180, 50, 50),
                _ => Color.Gray
            };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
