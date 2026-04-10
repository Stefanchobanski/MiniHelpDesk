using App.Models;
using App.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App.Services;

public class AdminService
{
    private readonly AdminRepository _adminRepository;

    public AdminService(AdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }

    public async Task ChangeUserRole(string userName, Role role)
    {
        CheckFields(userName);

        var user = await _adminRepository.GetUserByNameAsync(userName);

        if (user == null)
        {
            throw new InvalidOperationException($"User '{userName}' not found");
        }

        user.Role = role;

        await _adminRepository.UpdateAsync(user);
    }


    private void CheckFields(string userName)
    {
        if (string.IsNullOrEmpty(userName))
        {
            throw new FormatException("Username is empty");
        }
    }
}
