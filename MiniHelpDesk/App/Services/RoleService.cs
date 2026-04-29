using App.Models;
using App.Models.DTOs;
using App.Repositories.interfaces;
using App.Services.interfaces;
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

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task AddRole(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Role name cannot be null or empty.");
            }

            var role = await _roleRepository.GetRoleByName(name);

            if (role is not null)
            {
                throw new InvalidOperationException($"Role with name '{name}' already exists.");
            }

            role = new Role
            {
                Name = name
            };

            await _roleRepository.AddAsync(role);
        }


        public async Task<Role?> GetRoleByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Role name cannot be null or empty.");
            }

            Role role = await _roleRepository.GetRoleByName(name) ?? throw new InvalidOperationException($"Not found role with name: {name}");

            return role;
        }

        public async Task<List<RoleDTO>> GetRolesAsync()
        {
            var roles = await _roleRepository.GetRolesAsync() ?? throw new InvalidOperationException($"Not found roles");


            return roles;
        }

        public async Task RemoveRole(int id)
        {
            var role = await _roleRepository.GetByIdAsync(id) ?? throw new InvalidOperationException($"Not found role with id: {id}");

            if (role.Name == "Null"      ||
                role.Name == "Admin"     ||
                role.Name == "Techicial" ||
                role.Name == "Requester")
            {
                throw new InvalidOperationException("Cannot remove the 'Null', 'Admin', 'Techicial' or 'Requester' role.");
            }
            await _roleRepository.RemoveAndSetDeffaut(id);
        }

        public async Task UpdateRole(int id, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Role name cannot be null or empty.");
            }

            var role = await _roleRepository.GetByIdAsync(id) ?? throw new InvalidOperationException($"Not found roles"); ;

            if (role.Name == "Null"      ||
                role.Name == "Admin"     ||
                role.Name == "Techicial" ||
                role.Name == "Requester")
            {
                throw new InvalidOperationException("Cannot update the 'Null', 'Admin', 'Techicial' or 'Requester' role.");
            }

            role.Name = newName;

            await _roleRepository.UpdateAsync(role);
        }
    }
}
