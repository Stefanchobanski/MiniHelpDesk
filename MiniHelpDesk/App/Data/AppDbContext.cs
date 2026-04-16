using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHelpDesk.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MiniHelpDeskDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.UserID);

            entity.HasOne(e => e.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleID);

            entity.HasMany(u=> u.TicketToRequest)
            .WithOne(t=>t.Requester)
            .HasForeignKey(t=>t.RequesterId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

            entity.HasMany(u => u.TicketToTechnican)
            .WithOne(t => t.Technician)
            .HasForeignKey(t => t.TechnicianId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired(false);

            entity.HasMany(u => u.Comments)
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserID)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

            entity.HasMany(u => u.AuditLogs)
            .WithOne(a => a.UserChange)
            .HasForeignKey(a => a.ChangedByUserId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

            entity.Property(u => u.Username).IsRequired().HasMaxLength(50);
            entity.Property(u => u.Email).IsRequired().HasMaxLength(50);
            entity.Property(u => u.Password).IsRequired();
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(t => t.TicketId);

            entity.HasOne(t=>t.Category)
            .WithMany(c=>c.TicketList)
            .HasForeignKey(t=>t.CategoryId)
            .IsRequired();

            entity.HasMany(t => t.Attachments)
            .WithOne(a => a.Ticket)
            .HasForeignKey(a => a.TicketId)
            .IsRequired();

            entity.HasMany(t => t.Comments)
            .WithOne(c => c.Ticket)
            .HasForeignKey(c => c.TicketID)
            .IsRequired();

            entity.HasMany(t => t.AuditLogs)
            .WithOne(a => a.Ticket)
            .HasForeignKey(a => a.TicketId)
            .IsRequired();

            entity.Property(o => o.Status).HasConversion<string>();
            entity.Property(o => o.Priority).HasConversion<string>();
        });

    }
}
