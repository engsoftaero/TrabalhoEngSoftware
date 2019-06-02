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
using Microsoft.AspNetCore.Hosting;

namespace EngSoftwareForum
{
    [TestClass]
    public class AvatarControllerTest
    {
        private readonly IHostingEnvironment _appEnvironment;

        [TestMethod]
        public async Task AvatarControllerIndex()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new AvatarController(appEnvironment: _appEnvironment, db: _dbContext);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

    }
}
