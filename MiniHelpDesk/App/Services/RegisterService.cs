using App.Models;
using App.Repositories.interfaces;
using App.Services.interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHelpDesk.Services;

public class RegisterService : IRegisterService
{
    private readonly IRegisterUserRepository _registerRepository;
    private readonly ILogger<RegisterService> _logger;

    public RegisterService(IRegisterUserRepository registerRepository, ILogger<RegisterService> logger)
    {
        _registerRepository = registerRepository;
        _logger = logger;
    }

    public async Task AddUser(User user)
    {
        await _registerRepository.AddAsync(user);
    }
}
