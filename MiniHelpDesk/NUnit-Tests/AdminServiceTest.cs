using App.Repositories;
using App.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests;

public class AdminServiceTest
{
    private AdminService _adminService;
    private Mock<AdminRepository> _mockRepo;
    [SetUp]
    public void Setup()
    {
        _mockRepo = new Mock<AdminRepository>();
        _adminService = new AdminService(_mockRepo.Object);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
