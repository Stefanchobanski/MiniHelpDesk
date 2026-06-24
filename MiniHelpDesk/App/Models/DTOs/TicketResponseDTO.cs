using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.DTOs
{
    public class TicketResponseDTO
    {
        public int TicketId { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string? AssignedTo { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Title { get; set; }
        public string? Priority { get; set; }
        public int? RequesterId { get; set; }
        public int? TechnicianId { get; set; }
        public int? CategoryId { get; set; }
    }
}
