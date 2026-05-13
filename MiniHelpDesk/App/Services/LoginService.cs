using App.Repositories.interfaces;
using App.Services.Interfaces;
using Microsoft.Extensions.Logging;
using App.Models;

namespace App.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        private readonly ILogger<LoginService> _logger;

        public LoginService(ILoginRepository loginRepository, ILogger<LoginService> logger)
        {
            _loginRepository = loginRepository;
            _logger = logger;
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            ServiceHelper.CheckFields<LoginService>(username, _logger, "Username");
            ServiceHelper.CheckFields<LoginService>(password, _logger, "Password");

            var user = await _loginRepository.GetByUsernameAsync(username);

            if (user == null || user.Password != password)
            {
                _logger.LogWarning($"Failed login attempt for username '{username}'.");
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            _logger.LogInformation($"User '{username}' logged in successfully.");
            return user;
        }
    }
}
