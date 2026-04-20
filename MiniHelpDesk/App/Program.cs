using App.Forms;
using App.Models;
using App.Models.Enums;
using App.Repositories;
using App.Services;
using Microsoft.EntityFrameworkCore;
using MiniHelpDesk.Data;
using MiniHelpDesk.Services;
using System.Xml.Linq;

namespace App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using var db = new AppDbContext();
            //db.Categories.Add(new Category()
            //{
            //    Name = "IT"
            //});

            //db.Users.Add(new User()
            //{
            //    Username = "Technic",
            //    Password = "1`2211",
            //    Email = "32121@.121",
            //    RoleID = 2
            //});



            //db.Tickets.Add(new Ticket()
            //{
            //    RequesterId = 3,
            //    TechnicianId = 6,
            //    Title = "New Tickety",
            //    Description = "ddsdsdsdsdsdsds",
            //    Status = Status.New,
            //    Priority = Priority.High,
            //    CreatedDay = new DateTime(),
            //    Attachments = new List<Attachment>()
            //    {
            //        new Attachment()
            //        {
            //            FileName = "dsds",
            //            Path = "dsds/dsds/../"
            //        },
            //    },
            //    Comments = new List<Comment>()
            //    {
            //        new Comment()
            //        {
            //            UserID = 3,
            //            Text = "dsdsds",
            //            CreatedDate = DateTime.Now,
            //        }
            //    },
            //    AuditLogs = new List<AuditLog>()
            //    {
            //        new AuditLog()
            //        {
            //            ChangedByUserId = 6,
            //            Field = "dsds",
            //            OldValue = "dsds",
            //            NewValue = "Dsdsds",
            //            ChangedDate = DateTime.Now,
            //        }
            //    },

            //});



            db.Database.EnsureCreated();
            ApplicationConfiguration.Initialize();

            var adminRepo = new AdminRepository(db);

            var roleRepo = new RoleRepository(db);
            var serviceAdmin = new AdminService(adminRepo);
            var serviceRole = new RoleService(roleRepo);
            var categoryRepo = new CategoryRepository(db);
            var categoryServes = new CategoryService(categoryRepo);
            Application.Run(new AdminForm(serviceAdmin, serviceRole, categoryServes));
            var registerRepo = new RegisterUserRepository(db);
            var registerService = new RegisterService(registerRepo);
            //Application.Run(new RegisterForm(registerService, serviceRole));
        }
    }
}