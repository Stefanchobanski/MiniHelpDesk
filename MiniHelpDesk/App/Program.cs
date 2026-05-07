using App.Forms;
using App.Models;
using App.Models.Enums;
using App.Repositories;
using App.Services;
using Microsoft.Extensions.Logging;
using MiniHelpDesk.Data;
using MiniHelpDesk.Services;
using Serilog;

namespace App
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();

                using var db = new AppDbContext();

                Log.Logger = new LoggerConfiguration()
                    .WriteTo.File(
                        $"../../../logs/log_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt")
                    .CreateLogger();

                var loggerFactory = LoggerFactory.Create(builder =>
                 {
                     builder.AddSerilog();
                 });

                // ⚠️ FOR TESTING ONLY (reset DB each run)
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                // ======================
                // SEED DATA
                // ======================

                // ROLES
                var adminRole = new Role { Name = "Admin" };
                var techRole = new Role { Name = "Technician" };
                var userRole = new Role { Name = "Requester" };
                var nullRole = new Role { Name = "Null" };

                db.Roles.AddRange(adminRole, techRole, userRole, nullRole);
                db.SaveChanges();

                // USERS
                var admin = new User
                {
                    Username = "admin",
                    Email = "admin@mail.com",
                    Password = "1234",
                    RoleID = adminRole.RoleID
                };

                var tech = new User
                {
                    Username = "tech1",
                    Email = "tech@mail.com",
                    Password = "1234",
                    RoleID = techRole.RoleID
                };

                var user = new User
                {
                    Username = "user1",
                    Email = "user@mail.com",
                    Password = "1234",
                    RoleID = userRole.RoleID
                };

                db.Users.AddRange(admin, tech, user);
                db.SaveChanges();

                // CATEGORIES
                var hardware = new Category { Name = "Hardware" };
                var software = new Category { Name = "Software" };

                db.Categories.AddRange(hardware, software);
                db.SaveChanges();

                // TICKETS
                var ticket1 = new Ticket
                {
                    Title = "PC not starting",
                    Description = "Computer does not boot when power button is pressed",
                    Status = Status.New,
                    Priority = Priority.High,
                    CreatedAt = DateTime.Now,
                    CategoryId = hardware.CategoryId,
                    RequesterId = user.UserID,
                    TechnicianId = tech.UserID,
                    Email ="dsds"
                };

                var ticket2 = new Ticket
                {
                    Title = "Windows update error",
                    Description = "Update fails with error 0x80070002",
                    Status = Status.New,
                    Priority = Priority.Medium,
                    CreatedAt = DateTime.Now,
                    CategoryId = software.CategoryId,
                    RequesterId = user.UserID,
                    TechnicianId = tech.UserID,
                    Email = "dsdsada"
                };

                db.Tickets.AddRange(ticket1, ticket2);
                db.SaveChanges();

                // COMMENTS
                db.Comments.Add(new Comment
                {
                    Text = "We will check the power supply first.",
                    CreatedDate = DateTime.Now,
                    TicketID = ticket1.TicketId,
                    UserID = tech.UserID
                });

                db.Comments.Add(new Comment
                {
                    Text = "Try restarting Windows Update service.",
                    CreatedDate = DateTime.Now,
                    TicketID = ticket2.TicketId,
                    UserID = tech.UserID
                });

                db.SaveChanges();

                // ATTACHMENTS
                db.Attachments.Add(new Attachment
                {
                    FileName = "error.png",
                    Path = "/files/error.png",
                    TicketId = ticket2.TicketId
                });

                db.SaveChanges();

                // AUDIT LOGS
                db.AuditLogs.Add(new AuditLog
                {
                    Field = "Status",
                    OldValue = "New",
                    NewValue = "InProgress",
                    ChangedDate = DateTime.Now,
                    ChangedByUserId = tech.UserID,
                    TicketId = ticket2.TicketId
                });

                db.SaveChanges();

                // ======================
                // SERVICES + REPOS
                // ======================
                var adminRepo = new AdminRepository(db);
                var roleRepo = new RoleRepository(db);
                var categoryRepo = new CategoryRepository(db);
                var registerRepo = new RegisterUserRepository(db);

                var serviceAdmin = new AdminService(adminRepo, loggerFactory.CreateLogger<AdminService>());
                var serviceRole = new RoleService(roleRepo, loggerFactory.CreateLogger<RoleService>());
                var categoryService = new CategoryService(categoryRepo, loggerFactory.CreateLogger<CategoryService>());
                var registerService = new RegisterService(registerRepo);

                var ticketRepo = new TicketRepository(db);
                var tiketService = new TicketService(ticketRepo);

                // ======================
                // START APP
                // ======================
                Application.Run(new AdminForm(serviceAdmin, serviceRole, categoryService, tiketService));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "APP ERROR");
            }
            finally
            {
                Log.CloseAndFlush(); 
            }
        }
    }
}