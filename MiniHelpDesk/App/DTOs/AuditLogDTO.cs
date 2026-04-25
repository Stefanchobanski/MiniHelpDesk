using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTOs
{
    public class AuditLogDto
    {
        public string Id { get; set; } = string.Empty;
        public string Field { get; set; } = string.Empty;
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public DateTime ChangedDate { get; set; }
        public string ChangedByUserId { get; set; } = string.Empty;
        public string TicketId { get; set; } = string.Empty;
    }

    public class CreateAuditLogDto
    {
        public string Field { get; set; } = string.Empty;
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string ChangedByUserId { get; set; } = string.Empty;
        public string TicketId { get; set; } = string.Empty;
    }

    public class AuditLogFilterDto
    {
        public string? TicketId { get; set; }
        public string? ChangedByUserId { get; set; }
        public string? Field { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}