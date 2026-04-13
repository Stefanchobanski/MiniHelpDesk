using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    internal class Audit_Log
    {
        [Key]
        public string AuditLogId { get; set; }

        [Required]
        public string Field { get; set; }

        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public DateTime ChangedDate { get; set; }

        public string ChangedByUserId { get; set; }
        public string TicketId { get; set; }
    }
}
