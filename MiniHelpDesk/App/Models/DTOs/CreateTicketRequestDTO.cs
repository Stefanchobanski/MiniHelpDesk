using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.DTOs
{
    public class CreateTicketRequestDTO
    {
        public string Email { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
