using App.Models;

namespace App.Services.Interfaces
{
    public interface ILoginService
    {
        Task<string> LoginAsync(string username, string password);
    }
}
