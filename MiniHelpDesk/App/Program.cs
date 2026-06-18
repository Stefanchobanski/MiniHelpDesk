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

                // --- ТЕХНИЦИ ---
                var tech1 = new User
                {
                    Username = "tech1",
                    Email = "tech1@mail.com",
                    Password = "1234",
                    RoleID = techRole.RoleID
                };

                var tech2 = new User
                {
                    Username = "tech2",
                    Email = "tech2@mail.com",
                    Password = "1234",
                    RoleID = techRole.RoleID
                };

                var tech3 = new User
                {
                    Username = "tech3",
                    Email = "tech3@mail.com",
                    Password = "1234",
                    RoleID = techRole.RoleID
                };

                // --- РЕКУЕСТЪРИ ---
                var user1 = new User
                {
                    Username = "user1",
                    Email = "user1@mail.com",
                    Password = "1234",
                    RoleID = userRole.RoleID
                };

                var user2 = new User
                {
                    Username = "user2",
                    Email = "user2@mail.com",
                    Password = "1234",
                    RoleID = userRole.RoleID
                };

                var user3 = new User
                {
                    Username = "user3",
                    Email = "user3@mail.com",
                    Password = "1234",
                    RoleID = userRole.RoleID
                };

                db.Users.AddRange(admin, tech1, tech2, tech3, user1, user2, user3);
                db.SaveChanges();

                // CATEGORIES
                var hardware = new Category { Name = "Hardware" };
                var software = new Category { Name = "Software" };
                var network = new Category { Name = "Network" };
                var security = new Category { Name = "Security" };

                db.Categories.AddRange(hardware, software, network, security);
                db.SaveChanges();

                // TICKETS
                // --- user1 → разни техници ---
                var ticket1 = new Ticket
                {
                    Title = "PC not starting",
                    Description = "Computer does not boot when power button is pressed",
                    Status = Status.New,
                    Priority = Priority.High,
                    CreatedAt = DateTime.Now.AddDays(-10),
                    CategoryId = hardware.CategoryId,
                    RequesterId = user1.UserID,
                    TechnicianId = tech1.UserID,
                    Email = "user1@mail.com"
                };

                var ticket2 = new Ticket
                {
                    Title = "Windows update error",
                    Description = "Update fails with error 0x80070002",
                    Status = Status.InProgress,
                    Priority = Priority.Medium,
                    CreatedAt = DateTime.Now.AddDays(-8),
                    CategoryId = software.CategoryId,
                    RequesterId = user1.UserID,
                    TechnicianId = tech2.UserID,
                    Email = "user1@mail.com"
                };

                var ticket3 = new Ticket
                {
                    Title = "Cannot connect to VPN",
                    Description = "VPN client throws timeout error on connect",
                    Status = Status.New,
                    Priority = Priority.High,
                    CreatedAt = DateTime.Now.AddDays(-6),
                    CategoryId = network.CategoryId,
                    RequesterId = user1.UserID,
                    TechnicianId = tech3.UserID,
                    Email = "user1@mail.com"
                };

                var ticket4 = new Ticket
                {
                    Title = "Monitor flickering",
                    Description = "Screen flickers every few seconds, display driver reinstalled",
                    Status = Status.Resolved,
                    Priority = Priority.Low,
                    CreatedAt = DateTime.Now.AddDays(-14),
                    CategoryId = hardware.CategoryId,
                    RequesterId = user1.UserID,
                    TechnicianId = tech2.UserID,
                    Email = "user1@mail.com"
                };

                // --- user2 → разни техници ---
                var ticket5 = new Ticket
                {
                    Title = "Outlook not syncing",
                    Description = "Emails do not sync after recent Office update",
                    Status = Status.New,
                    Priority = Priority.Medium,
                    CreatedAt = DateTime.Now.AddDays(-3),
                    CategoryId = software.CategoryId,
                    RequesterId = user2.UserID,
                    TechnicianId = tech1.UserID,
                    Email = "user2@mail.com"
                };

                var ticket6 = new Ticket
                {
                    Title = "Printer offline",
                    Description = "Network printer shows offline, other PCs print fine",
                    Status = Status.InProgress,
                    Priority = Priority.Medium,
                    CreatedAt = DateTime.Now.AddDays(-5),
                    CategoryId = network.CategoryId,
                    RequesterId = user2.UserID,
                    TechnicianId = tech3.UserID,
                    Email = "user2@mail.com"
                };

                var ticket7 = new Ticket
                {
                    Title = "Suspected malware",
                    Description = "Antivirus flagged suspicious process running in background",
                    Status = Status.New,
                    Priority = Priority.High,
                    CreatedAt = DateTime.Now.AddDays(-1),
                    CategoryId = security.CategoryId,
                    RequesterId = user2.UserID,
                    TechnicianId = tech2.UserID,
                    Email = "user2@mail.com"
                };

                // --- user3 → разни техници ---
                var ticket8 = new Ticket
                {
                    Title = "Slow internet on workstation",
                    Description = "Download speed drops to under 1Mbps only on this machine",
                    Status = Status.New,
                    Priority = Priority.Low,
                    CreatedAt = DateTime.Now.AddDays(-2),
                    CategoryId = network.CategoryId,
                    RequesterId = user3.UserID,
                    TechnicianId = tech1.UserID,
                    Email = "user3@mail.com"
                };

                var ticket9 = new Ticket
                {
                    Title = "Blue screen on startup",
                    Description = "BSOD with IRQL_NOT_LESS_OR_EQUAL after Windows boot",
                    Status = Status.InProgress,
                    Priority = Priority.High,
                    CreatedAt = DateTime.Now.AddDays(-7),
                    CategoryId = hardware.CategoryId,
                    RequesterId = user3.UserID,
                    TechnicianId = tech3.UserID,
                    Email = "user3@mail.com"
                };

                var ticket10 = new Ticket
                {
                    Title = "Password reset request",
                    Description = "User locked out after multiple failed login attempts",
                    Status = Status.Resolved,
                    Priority = Priority.Medium,
                    CreatedAt = DateTime.Now.AddDays(-9),
                    CategoryId = security.CategoryId,
                    RequesterId = user3.UserID,
                    TechnicianId = tech2.UserID,
                    Email = "user3@mail.com"
                };

                db.Tickets.AddRange(ticket1, ticket2, ticket3, ticket4, ticket5,
                                    ticket6, ticket7, ticket8, ticket9, ticket10);
                db.SaveChanges();

                // COMMENTS
                db.Comments.AddRange(
                    new Comment { Text = "We will check the power supply first.", CreatedDate = DateTime.Now, TicketID = ticket1.TicketId, UserID = tech1.UserID },
                    new Comment { Text = "Try restarting Windows Update service.", CreatedDate = DateTime.Now, TicketID = ticket2.TicketId, UserID = tech2.UserID },
                    new Comment { Text = "Please share VPN logs.", CreatedDate = DateTime.Now, TicketID = ticket3.TicketId, UserID = tech3.UserID },
                    new Comment { Text = "Replaced display cable, issue resolved.", CreatedDate = DateTime.Now, TicketID = ticket4.TicketId, UserID = tech2.UserID },
                    new Comment { Text = "Running Office repair tool.", CreatedDate = DateTime.Now, TicketID = ticket5.TicketId, UserID = tech1.UserID },
                    new Comment { Text = "Checked spooler service, restarting now.", CreatedDate = DateTime.Now, TicketID = ticket6.TicketId, UserID = tech3.UserID },
                    new Comment { Text = "Isolating machine from network for scan.", CreatedDate = DateTime.Now, TicketID = ticket7.TicketId, UserID = tech2.UserID },
                    new Comment { Text = "Flushed DNS and reset TCP/IP stack.", CreatedDate = DateTime.Now, TicketID = ticket8.TicketId, UserID = tech1.UserID },
                    new Comment { Text = "Running memory diagnostics.", CreatedDate = DateTime.Now, TicketID = ticket9.TicketId, UserID = tech3.UserID },
                    new Comment { Text = "Password reset completed, user notified.", CreatedDate = DateTime.Now, TicketID = ticket10.TicketId, UserID = tech2.UserID }
                );
                db.SaveChanges();

                // ATTACHMENTS
                db.Attachments.AddRange(
                    new Attachment { FileName = "error.png", Path = "/files/error.png", TicketId = ticket2.TicketId },
                    new Attachment { FileName = "bsod.png", Path = "/files/bsod.png", TicketId = ticket9.TicketId },
                    new Attachment { FileName = "malware.log", Path = "/files/malware.log", TicketId = ticket7.TicketId }
                );
                db.SaveChanges();

                // AUDIT LOGS
                db.AuditLogs.AddRange(
                    new AuditLog { Field = "Status", OldValue = "New", NewValue = "InProgress", ChangedDate = DateTime.Now, ChangedByUserId = tech2.UserID, TicketId = ticket2.TicketId },
                    new AuditLog { Field = "Status", OldValue = "New", NewValue = "Resolved", ChangedDate = DateTime.Now, ChangedByUserId = tech2.UserID, TicketId = ticket4.TicketId },
                    new AuditLog { Field = "Status", OldValue = "New", NewValue = "InProgress", ChangedDate = DateTime.Now, ChangedByUserId = tech3.UserID, TicketId = ticket6.TicketId },
                    new AuditLog { Field = "Status", OldValue = "New", NewValue = "InProgress", ChangedDate = DateTime.Now, ChangedByUserId = tech3.UserID, TicketId = ticket9.TicketId },
                    new AuditLog { Field = "Status", OldValue = "New", NewValue = "Resolved", ChangedDate = DateTime.Now, ChangedByUserId = tech2.UserID, TicketId = ticket10.TicketId },
                    new AuditLog { Field = "Priority", OldValue = "Medium", NewValue = "Critical", ChangedDate = DateTime.Now, ChangedByUserId = tech2.UserID, TicketId = ticket7.TicketId }
                );
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

                var registerService = new RegisterService(registerRepo, loggerFactory.CreateLogger<RegisterService>(), roleRepo);

                var loginRepo = new LoginRepository(db);
                var loginService = new LoginService(loginRepo, loggerFactory.CreateLogger<LoginService>());

                var ticketRepo = new TicketRepository(db);
                var tiketService = new TicketService(ticketRepo, loggerFactory.CreateLogger<TicketService>());

                var commentRepo = new CommentRepository(db);
                var commentService = new CommentService(commentRepo, loggerFactory.CreateLogger<CommentService>());
                // ======================
                // START APP
                // ======================
                Application.Run(new RegisterForm(registerService, loginService, serviceAdmin, serviceRole, categoryService, tiketService, loggerFactory.CreateLogger<CategoriesForm>(), loggerFactory.CreateLogger<RoleAdminForm>(), loggerFactory.CreateLogger<TicketAdminForm>(), loggerFactory.CreateLogger<UserForm>(), commentService, loggerFactory.CreateLogger<TechnicianForm>(), loggerFactory.CreateLogger<CommentForm>()));
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