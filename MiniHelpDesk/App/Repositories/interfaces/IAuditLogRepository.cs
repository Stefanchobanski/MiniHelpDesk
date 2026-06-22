using App.DTOs;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.interfaces
{
    public interface IAuditLogRepository
    {
        Task<AuditLog?> GetByIdAsync(string id);
        Task<IEnumerable<AuditLog>> GetByTicketIdAsync(string ticketId);
        Task<IEnumerable<AuditLog>> GetByUserIdAsync(string userId);
        Task<IEnumerable<AuditLog>> GetFilteredAsync(AuditLogFilterDto filter);
        Task<AuditLog> CreateAsync(AuditLog auditLog);
        Task<IEnumerable<AuditLog>> CreateBulkAsync(IEnumerable<AuditLog> auditLogs);
        Task DeleteByTicketIdAsync(string ticketId);
    }
}
