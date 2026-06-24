using App.Models;
using App.Models.DTOs;
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

namespace App.Forms
{
    public partial class TicketForm : Form
    {
        private readonly ITicketService _ticketService;
        private readonly int _idRequester;
        public TicketForm(ITicketService ticketService, int idRequester)
        {
            InitializeComponent();
            _ticketService = ticketService;
            _idRequester = idRequester;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                 string.IsNullOrWhiteSpace(txtDescription.Text))
             {  
                MessageBox.Show("Please fill all fields!");
                return;
             }

            try
            {
                Ticket ticket = new Ticket()
                {
                    Email = txtEmail.Text,
                    Description = txtDescription.Text,
                    Title = txtTitle.Text,
                    Status = Models.Enums.Status.New,
                    Priority = Models.Enums.Priority.Low,
                    RequesterId = _idRequester
                };

                _ticketService.CreateTicket(ticket);

                MessageBox.Show("Ticket created successfully!");

                txtDescription.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
