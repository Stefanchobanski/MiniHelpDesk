using App.Models;
using App.Repositories;
using App.Repositories.interfaces;
using App.Services;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.IdentityModel.Tokens;
using MiniHelpDesk.Data;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests;

public class AdminServiceTest
{
    private AppDbContext _context;
    private AdminService _adminService;
    private Mock<IAdminRepository> _mockRepo;

    private void CreateUser()
    {

    }

    [SetUp]
    public void Setup()
    {
        _context = new AppDbContext();
        _mockRepo = new Mock<IAdminRepository>();
        var logger = NullLogger<AdminService>.Instance;
        _adminService = new AdminService(_mockRepo.Object, logger);
    }

    [TearDown]
    public void TearDown()
    {
        _context.Dispose();
    }

    #region ChangeUserRole()
    [Test]
    public async Task ChangeUserRole_ThrowExeptionFormat_Test()
    {
         Assert.ThrowsAsync<FormatException>(async () =>
            await _adminService.ChangeUserRole("   ", 1));

        _mockRepo.Verify(r => r.GetUserByNameAsync(It.IsAny<string>()), Times.Never);

        _mockRepo.Verify(r => r.UpdateAsync(It.IsAny<User>()), Times.Never);
    }
    [Test]
    public async Task ChangeUserRole_Success_Test()
    {
        User user = new User()
        {
            Username = "Pesho",
            RoleID = 1,
            Email = "peshp@dam.ca",
            Password = "12345678",
        };

        _mockRepo.Setup(r=>r.GetUserByNameAsync(user.Username))
            .ReturnsAsync(user);

        await _adminService.ChangeUserRole(user.Username, 2);

        Assert.That(user.RoleID, Is.EqualTo(2));

        _mockRepo.Verify(r => r.UpdateAsync(It.IsAny<User>()), Times.Once);
        _mockRepo.Verify(r => r.GetUserByNameAsync(It.IsAny<string>()), Times.Once);
    }
    [Test]
    public void ChangeUserRole_NotFoundUser_Test()
    {
        Assert.ThrowsAsync<InvalidOperationException>(async () =>
            await _adminService.ChangeUserRole("Pesho", 1));

        _mockRepo.Verify(r=> r.UpdateAsync(It.IsAny<User>()), Times.Never);
        _mockRepo.Verify(r => r.GetUserByNameAsync(It.IsAny<string>()), Times.Once);
    }
    #endregion

    #region GetAllUsers()
    [Test]
    public void GetAllUsers_Success_Test()
    {
        User user1 = new User()
        {

        };
    }
    #endregion
}
