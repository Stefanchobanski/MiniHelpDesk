using App.Models;
using App.Models.DTOs;
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

    private User CreateUser(string name, int roleId, string email, string password)
    {
        User user = new User()
        {
            Username = name,
            Email = email,
            Password = password,
            RoleID = roleId
        };
        return user;
    }

    private UserRoleDTO ConvertUserToDTO(User user)
    {
        return new UserRoleDTO()
        {
            UserId = user.UserID,
            UserName = user.Username,
            Email = user.Email,
            Role = user.Role.Name,
            RoleId = user.RoleID,
            Display = $"ID:{user.UserID} - {user.Username} - {user.Email} - {user.Role.Name}"
        };
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
    public void ChangeUserRole_ThrowExeptionFormat_Test()
    {
        Assert.ThrowsAsync<FormatException>(() =>
            _adminService.ChangeUserRole("   ", 1));

        _mockRepo.Verify(r => r.GetUserByNameAsync(It.IsAny<string>()), Times.Never);

        _mockRepo.Verify(r => r.UpdateAsync(It.IsAny<User>()), Times.Never);
    }
    [Test]
    public async Task ChangeUserRole_Success_Test()
    {
        User user = CreateUser("Ivan", 1, "dsds@ddsds.dsds", "12345666");

        _mockRepo.Setup(r => r.GetUserByNameAsync(user.Username))
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

        _mockRepo.Verify(r => r.UpdateAsync(It.IsAny<User>()), Times.Never);
        _mockRepo.Verify(r => r.GetUserByNameAsync(It.IsAny<string>()), Times.Once);
    }
    #endregion

    #region GetAllUsers()
    [Test]
    public async Task GetAllUsers_Success_Test()
    {
        User user1 = CreateUser("Ivan", 1, "dsds@ddsds.dsds", "12345666");
        User user2 = CreateUser("PEsho", 2, "dsdsdsgff2ds,s", "4343");

        List<User> users = new List<User>()
        { user1, user2 };

        _mockRepo.Setup(r => r.GetAllAsync())
            .ReturnsAsync(users);

        var result = await _adminService.GetAllUsers();

        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result[0].Username, Is.EqualTo("Ivan"));

        _mockRepo.Verify(r => r.GetAllAsync(), Times.Once);
    }
    [Test]
    public void GetAllUsers_ObjectIsNull_Test()
    {
        Assert.ThrowsAsync<InvalidOperationException>(() => _adminService.GetAllUsers());
    }
    #endregion

    #region GetUsersWithRole()
    [Test]
    public void GetUsersWithRole_Succes_Test()
    {
        var userDTO1 = ConvertUserToDTO(CreateUser("Mitko", 1, "dsds", "dsds"));
        var userDTO2 = ConvertUserToDTO(CreateUser("Ivan", 5, "e343", "5454"));

        List<UserRoleDTO> list = new List<UserRoleDTO>() { userDTO1,  userDTO2 };

        _mockRepo.Setup(r => r.GetAllUserWithRole()).ReturnsAsync(list);
    }
    #endregion
}
