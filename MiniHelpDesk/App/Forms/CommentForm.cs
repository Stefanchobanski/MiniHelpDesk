using App.Services;
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
    public partial class CommentForm : Form
    {
        private readonly TicketService _ticketService;
        private readonly CommentService _commentService;
        private readonly int _ticketId;
        private readonly Form _form;
        private readonly int _idUser;
        private readonly ILogger<CommentForm> _logger;

        public CommentForm(TicketService ticketService, int ticketId, CommentService commentService, Form form, int idUser, ILogger<CommentForm> logger)
        {
            _ticketService = ticketService;
            InitializeComponent();
            _ticketId = ticketId;
            _commentService = commentService;
            _form = form;
            _idUser = idUser;
            _logger = logger;
        }

        private async void CommentForm_Load(object sender, EventArgs e)
        {
            try
            {
                lstComments.DataSource = await _ticketService.GetTicketComments(_ticketId);
                lstComments.DisplayMember = "Display";
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message + " " + ex.StackTrace);
                MessageBox.Show("Възникна грешка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                _form.Show();
                _form.FormClosed += (s, args) => this.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + " " + ex.StackTrace);
                MessageBox.Show("Възникна грешка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                await _commentService.Add(txtComment.Text, DateTime.Now, _ticketId, _idUser);
                lstComments.DataSource = await _ticketService.GetTicketComments(_ticketId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + " " + ex.StackTrace);
                MessageBox.Show("Възникна грешка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            lblCharCount.Text = $"{txtComment.TextLength} / 500 символа";
            lblCharCount.ForeColor = txtComment.TextLength > 450
                ? Color.FromArgb(180, 50, 50)
                : Color.FromArgb(150, 150, 150);
        }
    }
}
