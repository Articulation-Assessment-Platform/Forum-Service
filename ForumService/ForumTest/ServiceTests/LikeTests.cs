using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Repositories.Interfaces;
using ForumServiceLayer.Models;
using ForumServiceLayer.Services;
using ForumServiceLayer.Services.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTest.ServiceTests
{
    [TestClass]
    public class LikeServiceTests
    {
        private Mock<ILikeRepository> _likeRepositoryMock;
        private LikeService _likeService;

        [TestInitialize]
        public void SetUp()
        {
            _likeRepositoryMock = new Mock<ILikeRepository>();
            _likeService = new LikeService(_likeRepositoryMock.Object);
        }

        [TestMethod]
        public async Task Create_NullLike_ThrowsArgumentNullException()
        {
            await Assert.ThrowsExceptionAsync<ArgumentNullException>(async () => await _likeService.Create(null));
        }

        [TestMethod]
        public async Task Create_ValidLike_ReturnsLikeModel()
        {
            // Arrange
            var likeModel = new LikeModel { PostId = 1, ResponseId = 2, UserId = 3 };
            var likeEntity = new LikeEntity { Id = 1, PostId = 1, ResponseId = 2, UserId = 3 };

            _likeRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<LikeEntity>())).ReturnsAsync(likeEntity);

            // Act
            var result = await _likeService.Create(likeModel);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(likeEntity.Id, result.Id);
            Assert.AreEqual(likeEntity.PostId, result.PostId);
            Assert.AreEqual(likeEntity.ResponseId, result.ResponseId);
            Assert.AreEqual(likeEntity.UserId, result.UserId);

            _likeRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<LikeEntity>()), Times.Once);
        }

        [TestMethod]
        public void Delete_NullLike_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => _likeService.Delete(null));
        }


        [TestMethod]
        public async Task GetAllPost_InvalidPostId_ThrowsArgumentException()
        {
            await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _likeService.GetAllPost(0));
        }

        [TestMethod]
        public async Task GetAllPost_ValidPostId_ReturnsLikeModels()
        {
            // Arrange
            var postId = 1;
            var likeEntities = new List<LikeEntity>
            {
                new LikeEntity { Id = 1, PostId = postId, ResponseId = 1, UserId = 1 },
                new LikeEntity { Id = 2, PostId = postId, ResponseId = 2, UserId = 2 }
            };

            _likeRepositoryMock.Setup(repo => repo.GetAllLikesPost(postId)).ReturnsAsync(likeEntities);

            // Act
            var result = await _likeService.GetAllPost(postId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(likeEntities.Count, result.Count);
            Assert.AreEqual(likeEntities[0].PostId, result[0].PostId);
            Assert.AreEqual(likeEntities[1].PostId, result[1].PostId);

            _likeRepositoryMock.Verify(repo => repo.GetAllLikesPost(postId), Times.Once);
        }

        [TestMethod]
        public async Task GetAllResponse_InvalidResponseId_ThrowsArgumentException()
        {
            await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _likeService.GetAllResponse(0));
        }

        [TestMethod]
        public async Task GetAllResponse_ValidResponseId_ReturnsLikeModels()
        {
            // Arrange
            var responseId = 1;
            var likeEntities = new List<LikeEntity>
            {
                new LikeEntity { Id = 1, PostId = 1, ResponseId = responseId, UserId = 1 },
                new LikeEntity { Id = 2, PostId = 2, ResponseId = responseId, UserId = 2 }
            };

            _likeRepositoryMock.Setup(repo => repo.GetAllLikesResponse(responseId)).ReturnsAsync(likeEntities);

            // Act
            var result = await _likeService.GetAllResponse(responseId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(likeEntities.Count, result.Count);
            Assert.AreEqual(likeEntities[0].ResponseId, result[0].ResponseId);
            Assert.AreEqual(likeEntities[1].ResponseId, result[1].ResponseId);

            _likeRepositoryMock.Verify(repo => repo.GetAllLikesResponse(responseId), Times.Once);
        }

        [TestMethod]
        public async Task GetAllUser_InvalidUserId_ThrowsArgumentException()
        {
            await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _likeService.GetAllUser(0));
        }

        [TestMethod]
        public async Task GetAllUser_ValidUserId_ReturnsLikeModels()
        {
            // Arrange
            var userId = 1;
            var likeEntities = new List<LikeEntity>
            {
                new LikeEntity { Id = 1, PostId = 1, ResponseId = 1, UserId = userId },
                new LikeEntity { Id = 2, PostId = 2, ResponseId = 2, UserId = userId }
            };

            _likeRepositoryMock.Setup(repo => repo.GetAllLikesUser(userId)).ReturnsAsync(likeEntities);

            // Act
            var result = await _likeService.GetAllUser(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(likeEntities.Count, result.Count);
            Assert.AreEqual(likeEntities[0].UserId, result[0].UserId);
            Assert.AreEqual(likeEntities[1].UserId, result[1].UserId);

            _likeRepositoryMock.Verify(repo => repo.GetAllLikesUser(userId), Times.Once);
        }
}
}