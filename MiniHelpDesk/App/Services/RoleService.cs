using App.Models;
using App.Models.DTOs;
using App.Repositories.interfaces;
using App.Services.interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly ILogger<RoleService> _logger;

        public RoleService(IRoleRepository roleRepository, ILogger<RoleService> logger)
        {
            _roleRepository = roleRepository;
            _logger = logger;
        }

        public async Task AddRole(string name)
        {
            ServiceHelper.CheckFields(name, _logger, "Ролята ");

            var role = await _roleRepository.GetRoleByName(name);

            if (role is not null)
            {
                _logger.LogError($"Ролята с име {name} съществува!");
                throw new InvalidOperationException($"Ролята съществува!");
            }

            role = new Role
            {
                Name = name
            };

            await _roleRepository.AddAsync(role);
        }


        public async Task<Role?> GetRoleByName(string name)
        {
            ServiceHelper.CheckFields(name, _logger, "Ролята ");

            Role role = await _roleRepository.GetRoleByName(name);

            ServiceHelper.ObjectIsNull(role, _logger);

            return role;
        }

        public async Task<List<RoleDTO>> GetRolesAsync()
        {
            var roles = await _roleRepository.GetRolesAsync();

            ServiceHelper.ObjectIsNull(roles, _logger);

            return roles;
        }

        public async Task RemoveRole(int id)
        {
            var role = await _roleRepository.GetByIdAsync(id); 

            ServiceHelper.ObjectIsNull(role, _logger);

            if (role.Name == "Null"      ||
                role.Name == "Admin"     ||
                role.Name == "Technician" ||
                role.Name == "Requester")
            {
                _logger.LogError($"Не можеш да премахнеш 'Null', 'Admin', 'Technician' or 'Requester' роли.");
                throw new InvalidOperationException("Не можеш да премахнеш 'Null', 'Admin', 'Technician' or 'Requester' роли.");
            }
            await _roleRepository.RemoveAndSetDeffaut(id);
        }

        public async Task UpdateRole(int id, string newName)
        {
            ServiceHelper.CheckFields(newName, _logger, "Ролята ");

            var role = await _roleRepository.GetByIdAsync(id);

            ServiceHelper.ObjectIsNull(role, _logger);

            if (role.Name == "Null"      ||
                role.Name == "Admin"     ||
                role.Name == "Technician" ||
                role.Name == "Requester")
            {
                _logger.LogError($"Не можеш да обновиш 'Null', 'Admin', 'Technician' or 'Requester' роли.");
                throw new InvalidOperationException("Не можеш да обновиш 'Null', 'Admin', 'Technician' or 'Requester' роли.");
            }

            role.Name = newName;

            await _roleRepository.UpdateAsync(role);
        }
    }
}
