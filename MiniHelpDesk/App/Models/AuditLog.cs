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
        public string AuditLogId { get; set; }
        public string Field { get; set; }

        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public DateTime ChangedDate { get; set; }

        public string ChangedByUserId { get; set; }
        public string TicketId { get; set; }

    }
}
