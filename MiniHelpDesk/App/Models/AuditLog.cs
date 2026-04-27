using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class AuditLog
    {
        public int AuditLogId { get; set; }
        public string Field { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime ChangedDate { get; set; }

        public int ChangedByUserId { get; set; }
        public User UserChange { get; set; }

        public int? TicketId { get; set; }
        public Ticket? Ticket { get; set; }
    }
}
