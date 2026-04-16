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
    private readonly IRoleRepository _roleRepository;

    public AdminService(IAdminRepository adminRepository, IRoleRepository roleRepository)
    {
        _adminRepository = adminRepository;
        _roleRepository = roleRepository;
    }

    public async Task ChangeUserRole(string userName, int id)
    {
        CheckFields(userName);

        var user = await _adminRepository.GetUserByNameAsync(userName);

        if (user == null)
        {
            throw new InvalidOperationException($"User '{userName}' not found");
        }

        user.RoleID = id;

        await _adminRepository.UpdateAsync(user);
    }

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _adminRepository.GetAllAsync();

        if (users == null)
        {
            throw new InvalidOperationException($"Not found users");
        }

        return users;
    }

    public async Task<List<UserRoleDTO>> GetUsersWithRole()
    {
        var users = await _adminRepository.GetAllUserWithRole();

        if(users == null)
        {
            throw new InvalidOperationException($"Not found users");
        }

        return users;
    }

    public async Task UpdateUsers(User user)
    {
        await _adminRepository.UpdateAsync(user);
    }

    public async Task<User?> GetUserById(int id)
    {
        var user = await _adminRepository.GetByIdAsync(id);

        if(user == null)
        {
            throw new InvalidOperationException($"Not found user");
        }

        return user;
    }
    public async Task<List<Role>> GetRolesAsync()
    {
        var roles = await _roleRepository.GetRolesAsync();

        if(roles == null)
        {
            throw new InvalidOperationException($"Not found roles");
        }

        return roles;
    }

    public async Task<User> GetByIdUser(int id)
    {
        return await _adminRepository.GetByIdAsync(id);
    }

    public async Task RemoveUser(int id)
    {
        await _adminRepository.DeleteAsync(id);
    }







    private void CheckFields(string userName)
    {
        if (string.IsNullOrEmpty(userName))
        {
            throw new FormatException("Username is empty");
        }
    }
}
