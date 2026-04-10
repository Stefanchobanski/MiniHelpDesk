using App.Models.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace App.Models;

public class Ticket
{
    public int TicketId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public Priority Priority { get; set; }
    public DateTime CreatedDay { get; set; }
    public Category Category { get; set; }

    public int RequesterId { get; set; }
    public User Requester { get; set; }

    public int? TechnicianId { get; set; }
    public User? Technician { get; set; }

    public List<Comment> Comments { get; set; } = new List<Comment>();
    public List<Attachment> Attachments { get; set; } = new List<Attachment>();
}
