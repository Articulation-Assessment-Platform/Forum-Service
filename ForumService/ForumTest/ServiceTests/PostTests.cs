using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForumAPI.Entities;
using ForumAPI.Services.Interfaces;
using ForumAPI.Models;
using ForumAPI.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ForumTest.ServiceTests
{
    [TestClass]
    public class PostServiceTests
    {
        private Mock<IPostRepository> _postRepositoryMock;
        private PostService _postService;

        [TestInitialize]
        public void SetUp()
        {
            _postRepositoryMock = new Mock<IPostRepository>();
            _postService = new PostService(_postRepositoryMock.Object);
        }

        [TestMethod]
        public async Task Create_NullPost_ThrowsArgumentException()
        {
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _postService.Create(null));
            Assert.AreEqual("Post cannot be null.", exception.Message);
        }

        [TestMethod]
        public async Task Create_ValidPost_ReturnsPostModel()
        {
            var postModel = new PostModel { Title = "Test", Content = "Content", AuthorId = 1, DateTime = DateTime.Now, Audience = "General", Url = "http://example.com", ForumId = 1 };
            var postEntity = new PostEntity { Id = 1, Title = "Test", Content = "Content", AuthorId = 1, DateTime = DateTime.Now, Audience = "General", Url = "http://example.com", ForumId = 1 };

            _postRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<PostEntity>())).ReturnsAsync(postEntity);

            var result = await _postService.Create(postModel);

            Assert.IsNotNull(result);
            Assert.AreEqual(postModel.Title, result.Title);
            _postRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<PostEntity>()), Times.Once);
        }

        [TestMethod]
        public async Task Update_NullPost_ThrowsArgumentException()
        {
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _postService.Update(null));
            Assert.AreEqual("Post cannot be null.", exception.Message);
        }

        [TestMethod]
        public async Task Update_PostNotFound_ThrowsArgumentException()
        {
            var postModel = new PostModel { Id = 1, Title = "Test" };

            _postRepositoryMock.Setup(repo => repo.GetByIdAsync(postModel.Id)).ReturnsAsync((PostEntity)null);

            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _postService.Update(postModel));
            Assert.AreEqual("There is no post found to update.", exception.Message);
        }

        [TestMethod]
        public async Task Update_ValidPost_UpdatesPost()
        {
            var postModel = new PostModel { Id = 1, Title = "Test", Content = "Content", DateTime = DateTime.Now, Audience = "General", AuthorId = 1, ForumId = 1 };
            var postEntity = new PostEntity { Id = 1, Title = "Test", Content = "Content", DateTime = DateTime.Now, Audience = "General", AuthorId = 1, ForumId = 1 };

            _postRepositoryMock.Setup(repo => repo.GetByIdAsync(postModel.Id)).ReturnsAsync(postEntity);

            await _postService.Update(postModel);

            _postRepositoryMock.Verify(repo => repo.Update(It.IsAny<PostEntity>()), Times.Once);
        }




        [TestMethod]
        public async Task Get_InvalidId_ThrowsArgumentException()
        {
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _postService.Get(0));
            Assert.AreEqual("Invalid post ID.", exception.Message);
        }

        [TestMethod]
        public async Task Get_PostNotFound_ThrowsArgumentException()
        {
            _postRepositoryMock.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PostEntity)null);

            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _postService.Get(1));
            Assert.AreEqual("Post not found.", exception.Message);
        }

        [TestMethod]
        public async Task GetAll_InvalidForumId_ThrowsArgumentException()
        {
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _postService.GetAll(0));
            Assert.AreEqual("Invalid forum ID.", exception.Message);
        }

        [TestMethod]
        public async Task GetAll_ValidForumId_ReturnsPostModels()
        {
            var postEntities = new List<PostEntity>
            {
                new PostEntity { Id = 1, Title = "Test1", Content = "Content1", AuthorId = 1, DateTime = DateTime.Now, Audience = "General", ForumId = 1 },
                new PostEntity { Id = 2, Title = "Test2", Content = "Content2", AuthorId = 2, DateTime = DateTime.Now, Audience = "General", ForumId = 1 }
            };

            _postRepositoryMock.Setup(repo => repo.GetByForumId(1)).ReturnsAsync(postEntities);

            var result = await _postService.GetAll(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            _postRepositoryMock.Verify(repo => repo.GetByForumId(1), Times.Once);
        }
    }
}
