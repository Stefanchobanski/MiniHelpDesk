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
        private readonly User _currentUser;
        private readonly ILogger<TicketAdminForm> _logger;
        public TechnicianForm(TicketService ticketService, User currentUser, ILogger<TicketAdminForm> logger)
        {
            InitializeComponent();
            _ticketService = ticketService;
            _currentUser = currentUser;
            _logger = logger;
        }
    }
}
