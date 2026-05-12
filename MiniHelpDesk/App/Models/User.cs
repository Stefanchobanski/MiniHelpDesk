using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models;

public class User
{
    public int UserID { get; set; }
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public int? RoleID { get; set; }
    public Role? Role { get; set; }

    public List<Comment> Comments { get; set; } = new List<Comment>();
    public List<Ticket> TicketToRequest { get; set; } = new List<Ticket>();
    public List<Ticket> TicketToTechnican { get; set; } = new List<Ticket>();
    public List<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
}
