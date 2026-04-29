using App.Models;
using App.Models.DTOs;
using App.Repositories.interfaces;
using App.Services.interfaces;
using System;
using System.Collections.Generic;
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

        public Task AddRole(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Role name cannot be null or empty.");
            }

            Role role = 

        }

        public Task<Role?> GetRoleById(int id)
        {
            throw new NotImplementedException();
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
            await _roleRepository.RemoveAndSetDeffaut(id);
        }
    }
}
