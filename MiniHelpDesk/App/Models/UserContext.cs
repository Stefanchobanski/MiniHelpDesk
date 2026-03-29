using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App.Models;

internal class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(u => u.UserID);
        modelBuilder.Entity<User>().Property(u => u.Username).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();

    }
}
