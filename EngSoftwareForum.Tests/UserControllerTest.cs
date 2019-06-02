using System.Data.Entity;
using EngSoftwareForum.Areas.Admin.Controllers;
using EngSoftwareForum.Data;
using EngSoftwareForum.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EngSoftwareForum
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public async Task UserControllerLock()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new UserController(_dbContext);

            // Act
            string id = "14n3l5n2l1";
            var result = await controller.Lock(id);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task UserControllerUnlock()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new UserController(_dbContext);

            // Act
            string id = "14n3l5n2l1";
            var result = await controller.UnLock(id);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

    }
}