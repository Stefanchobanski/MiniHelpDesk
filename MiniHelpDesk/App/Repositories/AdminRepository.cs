using App.Models;
using App.Models.DTOs;
using App.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using MiniHelpDesk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories;

public class AdminRepository : BaseRepository<User>, IAdminRepository
{
    public AdminRepository(AppDbContext db) : base(db) { }

    public async Task<List<UserRoleDTO>> GetAllUserWithRole()
    {
        return await _dbSet.Include(u => u.Role).Select(u => new UserRoleDTO
        {
            UserId = u.UserID,
            UserName = u.Username,
            Email = u.Email,
            Role = u.Role.Name,
            RoleId = u.RoleID,
            Display = $"ID:{u.UserID} - {u.Username} - {u.Email} - {u.Role.Name}"
        }).ToListAsync();
    }

    public async Task<User?> GetUserByNameAsync(string name)
    {
        return await _dbSet.FirstOrDefaultAsync(u => u.Username == name);
    }

    public async Task RemoveTicketByUserAllTabels(User user)
    {
        var tickets = _db.Tickets.Where(t => t.TechnicianId == user.UserID ||
            t.RequesterId == user.UserID);

        var ticketsId = tickets.Select(t => t.TicketId);

        var comments = _db.Comments
            .Where(c => ticketsId.Contains(c.TicketID));

        var attachments = _db.Attachments.Where(a => a.TicketId.HasValue &&
            ticketsId.Contains(a.TicketId.Value));

        var auditLogs = _db.AuditLogs.Where(a => a.TicketId.HasValue &&
            ticketsId.Contains(a.TicketId.Value));

        _db.Comments.RemoveRange(comments);
        _db.AuditLogs.RemoveRange(auditLogs);
        _db.Attachments.RemoveRange(attachments);

        _db.Tickets.RemoveRange(tickets);

        _db.Users.Remove(user);

        await _db.SaveChangesAsync();
    }
}
