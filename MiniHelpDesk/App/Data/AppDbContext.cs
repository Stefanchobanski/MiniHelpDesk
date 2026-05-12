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

            entity.HasIndex(u => u.Username)
            .IsUnique();

            entity.HasIndex(u => u.Email)
            .IsUnique();

            entity.HasOne(e => e.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleID)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

            entity.HasMany(u => u.TicketToRequest)
            .WithOne(t => t.Requester)
            .HasForeignKey(t => t.RequesterId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

            entity.HasMany(u => u.TicketToTechnican)
            .WithOne(t => t.Technician)
            .HasForeignKey(t => t.TechnicianId)
            .OnDelete(DeleteBehavior.SetNull)
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

            entity.Property(u => u.Username)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(50);

            entity.Property(u => u.Password)
            .IsRequired();
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(t => t.TicketId);

            entity.HasOne(t => t.Category)
            .WithMany(c => c.TicketList)
            .HasForeignKey(t => t.CategoryId)
            .OnDelete(DeleteBehavior.SetNull)
            .IsRequired(false);

            entity.HasMany(t => t.Attachments)
            .WithOne(a => a.Ticket)
            .HasForeignKey(a => a.TicketId)
            .IsRequired(false);

            entity.HasMany(t => t.Comments)
            .WithOne(c => c.Ticket)
            .HasForeignKey(c => c.TicketID)
            .IsRequired();

            entity.HasMany(t => t.AuditLogs)
            .WithOne(a => a.Ticket)
            .HasForeignKey(a => a.TicketId)
            .IsRequired(false);

            entity.Property(t => t.Status)
            .HasConversion<string>()
            .IsRequired();

            entity.Property(t => t.Priority)
            .HasConversion<string>()
            .IsRequired();

            entity.Property(t => t.Title)
            .HasMaxLength(50)
            .IsRequired();

            entity.Property(t => t.Description)
            .HasMaxLength(300)
            .IsRequired();

            entity.Property(t => t.CreatedAt)
            .IsRequired();

            entity.Property(t => t.Email)
            .HasMaxLength(50)
            .IsRequired();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(c => c.CategoryId);

            entity.HasIndex(c => c.Name)
            .IsUnique();
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(r => r.RoleID);

            entity.HasIndex(r => r.Name)
            .IsUnique();
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(a => a.AttachmentId);

            entity.Property(a => a.FileName)
            .HasMaxLength(20)
            .IsRequired();

            entity.Property(a => a.Path)
            .HasMaxLength(20)
            .IsRequired();
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(c => c.CommentID);

            entity.Property(c => c.Text)
            .HasMaxLength(200)
            .IsRequired();

            entity.Property(c => c.CreatedDate)
            .IsRequired();
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(a => a.AuditLogId);

            entity.Property(a=>a.Field)
            .HasMaxLength(100)
            .IsRequired();

            entity.Property(a => a.OldValue)
            .HasMaxLength(100)
            .IsRequired();

            entity.Property(a => a.NewValue)
            .HasMaxLength(100)
            .IsRequired();

            entity.Property(a => a.ChangedDate)
            .IsRequired();
        });
    }
}
