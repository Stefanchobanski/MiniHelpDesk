using App.DTOs;
using App.Models;
using App.Repositories.interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class AuditLogService : IAuditLogService
    {
        private readonly IAuditLogRepository _repository;
        private readonly ILogger<AuditLogService> _logger;

        public AuditLogService(IAuditLogRepository repository, ILogger<AuditLogService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<AuditLogDto?> GetByIdAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Audit log ID cannot be empty.", nameof(id));

            var auditLog = await _repository.GetByIdAsync(id);
            return auditLog is null ? null : MapToDto(auditLog);
        }

        public async Task<IEnumerable<AuditLogDto>> GetByTicketIdAsync(string ticketId)
        {
            if (string.IsNullOrWhiteSpace(ticketId))
                throw new ArgumentException("Ticket ID cannot be empty.", nameof(ticketId));

            var logs = await _repository.GetByTicketIdAsync(ticketId);
            return logs.Select(MapToDto);
        }

        public async Task<IEnumerable<AuditLogDto>> GetByUserIdAsync(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
                throw new ArgumentException("User ID cannot be empty.", nameof(userId));

            var logs = await _repository.GetByUserIdAsync(userId);
            return logs.Select(MapToDto);
        }

        public async Task<IEnumerable<AuditLogDto>> GetFilteredAsync(AuditLogFilterDto filter)
        {
            ArgumentNullException.ThrowIfNull(filter);

            if (filter.FromDate.HasValue && filter.ToDate.HasValue && filter.FromDate > filter.ToDate)
                throw new ArgumentException("FromDate must be earlier than ToDate.");

            var logs = await _repository.GetFilteredAsync(filter);
            return logs.Select(MapToDto);
        }

        public async Task<AuditLogDto> CreateAsync(CreateAuditLogDto dto)
        {
            ArgumentNullException.ThrowIfNull(dto);
            ValidateCreateDto(dto);

            var auditLog = new AuditLog
            {
                AuditLogId = Guid.NewGuid().ToString(),
                Field = dto.Field.Trim(),
                OldValue = dto.OldValue?.Trim(),
                NewValue = dto.NewValue?.Trim(),
                ChangedDate = DateTime.UtcNow,
                ChangedByUserId = dto.ChangedByUserId,
                TicketId = dto.TicketId
            };

            var created = await _repository.CreateAsync(auditLog);

            _logger.LogInformation(
                "Audit log created: ticket={TicketId}, field={Field}, changedBy={UserId}",
                created.TicketId, created.Field, created.ChangedByUserId);

            return MapToDto(created);
        }

        public async Task<IEnumerable<AuditLogDto>> CreateBulkAsync(IEnumerable<CreateAuditLogDto> dtos)
        {
            ArgumentNullException.ThrowIfNull(dtos);

            var dtoList = dtos.ToList();
            if (dtoList.Count == 0)
                return Enumerable.Empty<AuditLogDto>();

            foreach (var dto in dtoList)
                ValidateCreateDto(dto);

            var now = DateTime.UtcNow;
            var auditLogs = dtoList.Select(dto => new AuditLog
            {
                AuditLogId = Guid.NewGuid().ToString(),
                Field = dto.Field.Trim(),
                OldValue = dto.OldValue?.Trim(),
                NewValue = dto.NewValue?.Trim(),
                ChangedDate = now,
                ChangedByUserId = dto.ChangedByUserId,
                TicketId = dto.TicketId
            }).ToList();

            var created = await _repository.CreateBulkAsync(auditLogs);

            _logger.LogInformation(
                "Bulk audit logs created: {Count} entries for ticket={TicketId}",
                created.Count(), dtoList.First().TicketId);

            return created.Select(MapToDto);
        }

        public async Task DeleteByTicketIdAsync(string ticketId)
        {
            if (string.IsNullOrWhiteSpace(ticketId))
                throw new ArgumentException("Ticket ID cannot be empty.", nameof(ticketId));

            await _repository.DeleteByTicketIdAsync(ticketId);

            _logger.LogInformation("Audit logs deleted for ticket={TicketId}", ticketId);
        }
        private static void ValidateCreateDto(CreateAuditLogDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Field))
                throw new ArgumentException("Field name cannot be empty.");

            if (string.IsNullOrWhiteSpace(dto.ChangedByUserId))
                throw new ArgumentException("ChangedByUserId cannot be empty.");

            if (string.IsNullOrWhiteSpace(dto.TicketId))
                throw new ArgumentException("TicketId cannot be empty.");
        }

        private static AuditLogDto MapToDto(AuditLog log) => new()
        {
            Id = log.AuditLogId,
            Field = log.Field,
            OldValue = log.OldValue,
            NewValue = log.NewValue,
            ChangedDate = log.ChangedDate,
            ChangedByUserId = log.ChangedByUserId,
            TicketId = log.TicketId
        };
    }
}