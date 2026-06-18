using App.Models;
using App.Models.DTOs;
using App.Models.Enums;
using App.Services;
using Microsoft.Extensions.Logging;
namespace App.Forms
{
    public partial class TechnicianForm : Form
    {
        private readonly TicketService _ticketService;
        private readonly ILogger<TechnicianForm> _logger;
        private readonly ILogger<CommentForm> _commentFormLogger;
        private readonly CommentService _commentService;
        private readonly int _technicianId;
        public TechnicianForm(TicketService ticketService, ILogger<TechnicianForm> logger, int id, CommentService commentService, ILogger<CommentForm> commentFormLogger)
        {
            InitializeComponent();
            _ticketService = ticketService;
            _logger = logger;
            _technicianId = id;
            _commentService = commentService;
            _commentFormLogger = commentFormLogger;
        }

        private async void TechnicianForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<User> users = await _ticketService.GetTechnicianUsers(_technicianId);
                lbUsers.DataSource = users;
                lbUsers.DisplayMember = "Username";
                lbUsers.ValueMember = "UserID";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + " " + ex.StackTrace);
                MessageBox.Show("Грешка при зареждане на информация", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            try
            {
                var ticketForm = new TicketAdminForm(this, _ticketService, (int)lbUsers.SelectedValue, _logger, _commentService, _technicianId, _commentFormLogger);

                this.Hide();
                ticketForm.FormClosed += (s, args) => this.Show();
                ticketForm.Show();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message + " " + ex.StackTrace);
                MessageBox.Show("Възникна грешка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
