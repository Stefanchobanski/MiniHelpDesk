using App.Models;
using App.Models.DTOs;
using App.Repositories;
using App.Repositories.interfaces;
using App.Services.interfaces;
using Microsoft.EntityFrameworkCore;
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

    public AdminService(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }

    public async Task ChangeUserRole(string userName, int id)
    {
        CheckFields(userName);

        var user = await _adminRepository.GetUserByNameAsync(userName) ?? throw new InvalidOperationException($"User '{userName}' not found");

        user.RoleID = id;

        await _adminRepository.UpdateAsync(user);
    }

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _adminRepository.GetAllAsync() ?? throw new InvalidOperationException($"Not found users");

        return users;
    }

    public async Task<List<UserRoleDTO>> GetUsersWithRole()
    {
        var users = await _adminRepository.GetAllUserWithRole() ?? throw new InvalidOperationException($"Not found users");

        return users;
    }

    public async Task UpdateUsers(int id, string name, string email, int roleId)
    {
        if(string.IsNullOrWhiteSpace(name)   || 
            string.IsNullOrWhiteSpace(email))
        {
            throw new FormatException("Username or email is empty");
        }

        var user = await _adminRepository.GetByIdAsync(id) ?? throw new InvalidOperationException($"Not found user");
        user.Username = name;
        user.Email = email;
        user.RoleID = roleId;

        await _adminRepository.UpdateAsync(user);
    }

    public async Task<User?> GetUserById(int id)
    {
        var user = await _adminRepository.GetByIdAsync(id) ?? throw new InvalidOperationException($"Not found user");

        return user;
    }

    public async Task<User> GetByIdUser(int id)
    {
        return await _adminRepository.GetByIdAsync(id) ?? throw new InvalidOperationException($"Not found user");
    }

    public async Task RemoveUser(int id)
    {
        await _adminRepository.DeleteAsync(id);
    }

    public async Task RemoveAddUserWithTables(int id)
    {
        var user = await _adminRepository.GetByIdAsync(id) ?? throw new IndexOutOfRangeException("Invalid user");

        await _adminRepository.RemoveTicketByUserAllTabels(user);
    }





    private void CheckFields(string userName)
    {
        if (string.IsNullOrEmpty(userName))
        {
            throw new FormatException("Username is empty");
        }
    }

}
