using App;
using App.Models;
using App.Repositories.interfaces;
using App.Services.interfaces;
using Microsoft.Extensions.Logging;

namespace MiniHelpDesk.Services;

public class RegisterService : IRegisterService
{
    private readonly IRegisterUserRepository _registerRepository;
    private readonly IRoleRepository _roleRepository;
    private readonly ILogger<RegisterService> _logger;

    public RegisterService(IRegisterUserRepository registerRepository, ILogger<RegisterService> logger, IRoleRepository roleRepository)
    {
        _registerRepository = registerRepository;
        _logger = logger;
        _roleRepository = roleRepository;
    }

    public async Task RegisterUser(string username, string email, string password)
    {
        ServiceHelper.CheckFields<RegisterService>(username, _logger, "Username");
        ServiceHelper.CheckFields<RegisterService>(email, _logger, "Email");
        ServiceHelper.CheckFields<RegisterService>(password, _logger, "Password");

        if (!email.Contains('@') || !email.Contains('.'))
        {
            _logger.LogWarning("Invalid email format.");
            throw new FormatException("Please enter a valid email address.");
        }

        if (password.Length < 6)
        {
            _logger.LogWarning("Password too short.");
            throw new ArgumentException("Password must be at least 6 characters long.");
        }

        bool usernameTaken = await _registerRepository.ExistsByUsernameAsync(username);
        if (usernameTaken)
        {
            _logger.LogWarning($"Username '{username}' is already taken.");
            throw new InvalidOperationException($"Username '{username}' is already taken.");
        }

        bool emailTaken = await _registerRepository.ExistsByEmailAsync(email);
        if (emailTaken)
        {
            _logger.LogWarning($"Email '{email}' is already registered.");
            throw new InvalidOperationException($"Email '{email}' is already registered.");
        }
        var user = new User
        {
            Username = username,
            Email = email,
            Password = password,
            Role = await _roleRepository.GetRoleByName("Requester")
        };

        await _registerRepository.AddAsync(user);
        _logger.LogInformation($"User '{username}' registered successfully.");
    }
}
