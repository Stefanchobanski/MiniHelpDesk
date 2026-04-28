using App.Models;
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

        public async Task<List<Role>> GetRolesAsync()
        {
            var roles = await _roleRepository.GetRolesAsync();

            if (roles == null)
            {
                throw new InvalidOperationException($"Not found roles");
            }

            return roles;
        }
    }
}
