using App.Models;
using App.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHelpDesk.Services;

public class RegisterService : IRegisterService
{
    public Task<List<Role>> GetRolesAsync()
    {
        throw new NotImplementedException();
    }
}
