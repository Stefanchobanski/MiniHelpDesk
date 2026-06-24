using App.Models;

namespace App.Services.Interfaces
{
    public interface ILoginService
    {
        Task<User> LoginAsync(string username, string password);
    }
}
