using App.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.interfaces
{
    public interface IAuditLogService
    {
        Task<AuditLogDto?> GetByIdAsync(string id);
        Task<IEnumerable<AuditLogDto>> GetByTicketIdAsync(string ticketId);
        Task<IEnumerable<AuditLogDto>> GetByUserIdAsync(string userId);
        Task<IEnumerable<AuditLogDto>> GetFilteredAsync(AuditLogFilterDto filter);
        Task<AuditLogDto> CreateAsync(CreateAuditLogDto dto);
        Task<IEnumerable<AuditLogDto>> CreateBulkAsync(IEnumerable<CreateAuditLogDto> dtos);
        Task DeleteByTicketIdAsync(string ticketId);
    }
}
