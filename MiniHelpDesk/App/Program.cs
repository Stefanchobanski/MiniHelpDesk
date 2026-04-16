using App.Forms;
using App.Models;
using App.Models.Enums;
using App.Repositories;
using App.Services;
using MiniHelpDesk.Data;
using MiniHelpDesk.Services;

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
            db.Database.EnsureCreated();
            ApplicationConfiguration.Initialize();
           
            var adminRepo = new AdminRepository(db);
            var roleRepo = new RoleRepository(db);
            var serviceAdmin = new AdminService(adminRepo);
            var serviceRole = new RoleService(roleRepo);
            Application.Run(new AdminForm(serviceAdmin, serviceRole));
            var registerRepo = new RegisterUserRepository(db);
            var registerService = new RegisterService(registerRepo);
            //Application.Run(new RegisterForm(registerService, serviceRole));
        }
    }
}