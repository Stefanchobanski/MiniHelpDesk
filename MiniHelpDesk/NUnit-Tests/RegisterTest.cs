using App.Models;
using App.Repositories;
using App.Repositories.interfaces;
using Microsoft.Extensions.Logging.Abstractions;
using MiniHelpDesk.Services;
using Moq;

namespace NUnit_Tests;

public class RegisterTest
{

    private RegisterService _registerService;
    private Mock<IRegisterUserRepository> _registerUserRepoMock;
    private Mock<IRoleRepository> _roleRepoMock;

    private User CreateUser(string username, string email, string password)
    {
        return new User
        {
            Username = username,
            Email = email,
            Password = password
        };
    }

    [SetUp]
    public void Setup()
    {
        _registerUserRepoMock = new Mock<IRegisterUserRepository>();
        _roleRepoMock = new Mock<IRoleRepository>();
        var logger = NullLogger<RegisterService>.Instance;
        _registerService = new RegisterService(_registerUserRepoMock.Object, logger, _roleRepoMock.Object);
    }

    [TearDown]
    public void TearDown() { }

    #region RegisterUser()

    [Test]
    public void RegisterUser_EmptyUsername_ThrowsFormatException()
    {
        Assert.ThrowsAsync<FormatException>(() =>
            _registerService.RegisterUser("   ", "test@test.com", "password123"));

        _registerUserRepoMock.Verify(r => r.ExistsByUsernameAsync(It.IsAny<string>()), Times.Never);
        _registerUserRepoMock.Verify(r => r.AddAsync(It.IsAny<User>()), Times.Never);
    }

    [Test]
    public void RegisterUser_EmptyEmail_ThrowsFormatException()
    {
        Assert.ThrowsAsync<FormatException>(() =>
            _registerService.RegisterUser("testuser", "   ", "password123"));

        _registerUserRepoMock.Verify(r => r.AddAsync(It.IsAny<User>()), Times.Never);
    }

    [Test]
    public void RegisterUser_EmptyPassword_ThrowsFormatException()
    {
        Assert.ThrowsAsync<FormatException>(() =>
            _registerService.RegisterUser("testuser", "test@test.com", "   "));

        _registerUserRepoMock.Verify(r => r.AddAsync(It.IsAny<User>()), Times.Never);
    }

    #endregion
}
