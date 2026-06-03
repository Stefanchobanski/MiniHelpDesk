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
        private readonly int _userId;

        private readonly ILogger<TicketAdminForm> _logger;

        public TicketAdminForm(UserForm userForm, TicketService ticketService, int userId, ILogger<TicketAdminForm> logger)
        {
            InitializeComponent();
            _userForm = userForm;
            _ticketService = ticketService;
            _userId = userId;
            _logger = logger;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _userForm.Show();
            _userForm.FormClosed += (s, args) => this.Close();
            this.Close();
        }

        private async void TicketAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTikets.DataSource = await _ticketService.GetAllTicketsForUser(_userId);
                dgvTikets.Columns["TicketId"].ReadOnly = true;
                dgvTikets.Columns["CreatedAt"].ReadOnly = true;
                dgvTikets.Columns["RequesterId"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
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
                _logger.LogError(ex.Message);
                MessageBox.Show($"Грешка при обновяване на информация!");
            }
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTikets.SelectedRows.Count == 0)
            {
                _logger.LogWarning("Не е селектиран тикет");
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

                    dgvTikets.DataSource = await _ticketService.GetAllTicketsForUser(_userId);

                    MessageBox.Show("Успешно изтриване!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    MessageBox.Show("Грешка при изтриване на информация!");
                }
            }
        }
    }
}
