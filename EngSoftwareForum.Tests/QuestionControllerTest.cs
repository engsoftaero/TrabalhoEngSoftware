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
    public class QuestionControllerTest
    {
        [TestMethod]
        public async Task QuestionsControllerIndex()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(int));
        }
    }
}
