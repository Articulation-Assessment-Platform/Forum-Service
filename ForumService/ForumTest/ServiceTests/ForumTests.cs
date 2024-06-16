using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Services.Interfaces;
using ForumServiceLayer.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTest.ServiceTests
{
    [TestClass]
    public class ForumServiceTests
    {
        private Mock<IForumRepository> _forumRepositoryMock;
        private ForumService _forumService;

        [TestInitialize]
        public void SetUp()
        {
            _forumRepositoryMock = new Mock<IForumRepository>();
            _forumService = new ForumService(_forumRepositoryMock.Object);
        }

        [TestMethod]
        public async Task GetForums_ReturnsForumModels()
        {
            // Arrange
            var privacy = "public";
            var forumEntities = new List<ForumEntity>
            {
                new ForumEntity { Id = 1, CategoryName = "General", Description = "General discussions", Audience = "Public" },
                new ForumEntity { Id = 2, CategoryName = "Articulation", Description = "Articulation discussions", Audience = "Public" }
            };

            _forumRepositoryMock.Setup(repo => repo.GetAllForums(privacy)).ReturnsAsync(forumEntities);

            // Act
            var result = await _forumService.GetForums(privacy);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(forumEntities.Count, result.Count);

            for (int i = 0; i < forumEntities.Count; i++)
            {
                Assert.AreEqual(forumEntities[i].Id, result[i].Id);
                Assert.AreEqual(forumEntities[i].CategoryName, result[i].CategoryName);
                Assert.AreEqual(forumEntities[i].Description, result[i].Description);
                Assert.AreEqual(forumEntities[i].Audience, result[i].Audience);
            }

            _forumRepositoryMock.Verify(repo => repo.GetAllForums(privacy), Times.Once);
        }
    }
}
