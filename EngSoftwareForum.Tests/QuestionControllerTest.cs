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
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }


        [TestMethod]
        public async Task QuestionsControllerCreate()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.Create();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public async Task QuestionsControllerEdit()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.Edit(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task QuestionsControllerDelete()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.Delete(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task QuestionsControllerEditReply()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.EditReply(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task QuestionsControllerDeleteReply()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.DeleteReply(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task QuestionsControllerDetails()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.Details(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task QuestionsControllerAnswer()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.Answer(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task QuestionsControllerUpVoteQuestion()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.UpvoteQuestion(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task QuestionsControllerDownVoteQuestion()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.DownvoteQuestion(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task QuestionsControllerUpvoteReplies()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.UpvoteReplies(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
        }

        [TestMethod]
        public async Task QuestionsControllerDownvoteReplies()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseInMemoryDatabase();
            var _dbContext = new ApplicationDbContext(optionsBuilder.Options);

            var controller = new QuestionsController(_dbContext);

            // Act
            var result = await controller.DownvoteReplies(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
        }

    }
}
