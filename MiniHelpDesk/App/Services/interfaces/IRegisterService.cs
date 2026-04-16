using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.interfaces
{
    public interface IRegisterService
    {
        Task<List<Role>> GetRolesAsync();
    }
}
