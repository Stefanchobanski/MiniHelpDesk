using App.Models;
using App.Models.DTOs;
using App.Services;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public partial class TicketAdminForm : Form
    {
        private readonly UserForm _userForm;
        private readonly TicketService _ticketService;
        private readonly int _requesterId;

        private readonly CommentService _commentService;

        private readonly ILogger<TicketAdminForm> _ticketLogger;
        private readonly ILogger<TechnicianForm> _technicianLogger;
        private readonly ILogger<CommentForm> _commentFormLogger;

        private readonly bool _isTechnich = false;
        private readonly int _userid;

        public TicketAdminForm(UserForm userForm, TicketService ticketService, int userId, ILogger<TicketAdminForm> logger, CommentService commentService, int id, ILogger<CommentForm> commentFormLogger, ILogger<TechnicianForm> technicianLogger)
        {
            InitializeComponent();
            _userForm = userForm;
            _ticketService = ticketService;
            _requesterId = userId;
            _ticketLogger = logger;
            _isTechnich = false;
            _commentService = commentService;
            _userid = id;
            _commentFormLogger = commentFormLogger;
            _technicianLogger = technicianLogger;
        }

        private readonly TechnicianForm _techForm;
        public TicketAdminForm(TechnicianForm technicianForm, TicketService ticketService, int userId, ILogger<TechnicianForm> logger, CommentService commentService, int techId, ILogger<CommentForm> commentFormLogger)
        {
            InitializeComponent();
            _techForm = technicianForm;
            _ticketService = ticketService;
            _requesterId = userId;
            _technicianLogger = logger;
            _isTechnich = true;
            _userid = techId;
            _commentService = commentService;
            _commentFormLogger = commentFormLogger;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isTechnich)
                {
                    _techForm.Show();
                    _techForm.FormClosed += (s, args) => this.Close();
                    this.Close();
                }
                else
                {
                    _userForm.Show();
                    _userForm.FormClosed += (s, args) => this.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                _technicianLogger.LogError(ex.Message);
                MessageBox.Show($"Грешка при връщането на формата");
            }
        }

        private async void TicketAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_isTechnich)
                {
                    dgvTikets.DataSource = await _ticketService.GetAllTicketTechnic(_userid, _requesterId);
                }
                else
                {
                    dgvTikets.DataSource = await _ticketService.GetAllTicketsForUser(_requesterId);
                }


                dgvTikets.Columns["TicketId"].ReadOnly = true;
                dgvTikets.Columns["CreatedAt"].ReadOnly = true;
                dgvTikets.Columns["RequesterId"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                _technicianLogger.LogError(ex.Message);
                MessageBox.Show($"Грешка при зареждане на информация!");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var tikets = dgvTikets.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => row.DataBoundItem != null)
                    .Select(row => (TicketResponseDTO)row.DataBoundItem)
                    .ToList();

                foreach (var ticketDTO in tikets)
                {
                    await _ticketService.UpdateTicket(ticketDTO);
                }
                dgvTikets.DataSource = _ticketService.GetAllTickets().ToList();
            }
            catch (Exception ex)
            {
                _technicianLogger.LogError(ex.Message);
                MessageBox.Show($"Грешка при обновяване на информация!");
            }
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTikets.SelectedRows.Count == 0)
            {
                _technicianLogger.LogWarning("Не е селектиран тикет");
                MessageBox.Show("Моля, изберете ред за изтриване!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
            "Сигурни ли сте, че искате да изтриете избрания билет?",
            "Потвърждение за изтриване",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dgvTikets.SelectedRows)
                    {
                        var ticketDTO = (TicketResponseDTO)row.DataBoundItem;

                        await _ticketService.DeleteTicket(ticketDTO.TicketId);
                    }

                    dgvTikets.DataSource = await _ticketService.GetAllTicketsForUser(_requesterId);

                    MessageBox.Show("Успешно изтриване!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    _technicianLogger.LogError(ex.Message);
                    MessageBox.Show("Грешка при изтриване на информация!");
                }
            }
        }

        private void btnComments_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTikets.CurrentRow != null && dgvTikets.CurrentRow.DataBoundItem is TicketResponseDTO ticketDto)
                {
                    int idTicket = ticketDto.TicketId;
                    CommentForm commentForm = new CommentForm(_ticketService, idTicket, _commentService, this, _userid, _commentFormLogger);
                    commentForm.FormClosed += (s, args) => this.Show();
                    commentForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                _technicianLogger.LogError(ex.Message + " " + ex.StackTrace);
                MessageBox.Show("Грешка при зареждане на формата");
            }
        }
    }
}
