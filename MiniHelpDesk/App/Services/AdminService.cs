using App.Models;
using App.Models.DTOs;
using App.Repositories;
using App.Repositories.interfaces;
using App.Services.interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services;

public class AdminService : IAdminService
{
    private readonly IAdminRepository _adminRepository;
    private readonly ILogger<AdminService> _logger;
    public AdminService(IAdminRepository adminRepository, ILogger<AdminService> logger)
    {
        _adminRepository = adminRepository;
        _logger = logger;
    }

    public async Task ChangeUserRole(string userName, int id)
    {
        ServiceHelper.CheckFields(userName, _logger, "Потребителското име ");

        var user = await _adminRepository.GetUserByNameAsync(userName);

        ServiceHelper.ObjectIsNull(user, _logger);

        _logger.LogInformation($"Потребителят: {userName} е намерен в базата данни! Сменям ролята му на {id}!");

        user.RoleID = id;

        await _adminRepository.UpdateAsync(user);
    }

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _adminRepository.GetAllAsync();

        ServiceHelper.ObjectIsNull(users, _logger);

        _logger.LogInformation($"Намерени са {users.Count} потребители в базата данни!");

        return users;
    }

    public async Task<List<UserRoleDTO>> GetUsersWithRole()
    {
        var users = await _adminRepository.GetAllUserWithRole();

        ServiceHelper.ObjectIsNull(users, _logger);

        _logger.LogInformation($"Намерени са {users.Count} потребители в базата данни!");

        return users;
    }

    public async Task UpdateUsers(int id, string name, string email, int roleId)
    {
        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(email))
        {
            _logger.LogWarning($"Потребителското име или имейлът са празни!");
            throw new FormatException("Потребителското име или имейлът са празни!");
        }

        _logger.LogInformation($"Потребителското име и имейлът са валидни! Продължавам с обновяването на потребителя с ID: {id}!");

        var user = await _adminRepository.GetByIdAsync(id);

        ServiceHelper.ObjectIsNull(user, _logger);

        _logger.LogInformation($"Потребител с ID: {id} е намерен в базата данни! Обновявам информацията му!");

        user.Username = name;
        user.Email = email;
        user.RoleID = roleId;

        await _adminRepository.UpdateAsync(user);
    }

    public async Task<User?> GetByIdUser(int id)
    {
        var user = await _adminRepository.GetByIdAsync(id);

        ServiceHelper.ObjectIsNull(user, _logger);

        _logger.LogInformation($"Потребител с ID: {id} е намерен в базата данни!");

        return user;
    }

    public async Task RemoveUser(int id)
    {
        await _adminRepository.DeleteAsync(id);
        _logger.LogInformation($"Потребител с ID: {id} е изтрит от базата данни!");
    }

    public async Task RemoveAddUserWithTables(int id)
    {
        var user = await _adminRepository.GetByIdAsync(id);

        ServiceHelper.ObjectIsNull(user, _logger);
        _logger.LogInformation($"Потребител с ID: {id} е намерен в базата данни! Продължавам с изтриването на свързаните таблици!");

        await _adminRepository.RemoveTicketByUserAllTabels(user);
    }
}
