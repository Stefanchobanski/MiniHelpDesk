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
        public TicketForm(ITicketService ticketService)
        {
            InitializeComponent();
            _ticketService = ticketService;
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
                var request = new CreateTicketRequestDTO
                {
                    Email = txtEmail.Text,
                    Description = txtDescription.Text
                };

                _ticketService.CreateTicket(request);

                MessageBox.Show("Ticket created successfully!");

                txtDescription.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
