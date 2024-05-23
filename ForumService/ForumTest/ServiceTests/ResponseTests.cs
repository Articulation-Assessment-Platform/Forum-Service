using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Services.Interfaces;
using ForumServiceLayer.Models;
using ForumServiceLayer.Services;
using Moq;

namespace ForumServiceLayer.Tests
{
    [TestClass]
    public class ResponseServiceTests
    {
        [TestMethod]
        public async Task Create_ValidResponse_ReturnsResponseModel()
        {
            // Arrange
            var responseRepositoryMock = new Mock<IResponseRepository>();
            var responseService = new ResponseService(responseRepositoryMock.Object);
            var responseModel = new ResponseModel
            {
                Content = "Test content",
                AuthorId = 123,
                DateTime = DateTime.UtcNow,
                Audience = "Test audience",
                Url = "http://example.com",
                ResponseId = 456
            };

            responseRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<ResponseEntity>()))
                                  .ReturnsAsync(new ResponseEntity { Id = 1 }); // Assuming it returns a newly created entity with an ID

            // Act
            var createdResponse = await responseService.Create(responseModel);

            // Assert
            Assert.IsNotNull(createdResponse);
            Assert.AreEqual(1, createdResponse.Id); // Assuming the ID is set correctly
            Assert.AreEqual(responseModel.Content, createdResponse.Content);
            Assert.AreEqual(responseModel.AuthorId, createdResponse.AuthorId);
            Assert.AreEqual(responseModel.DateTime, createdResponse.DateTime);
            Assert.AreEqual(responseModel.Audience, createdResponse.Audience);
            Assert.AreEqual(responseModel.Url, createdResponse.Url);
            Assert.AreEqual(responseModel.ResponseId, createdResponse.ResponseId);
        }

        [TestMethod]
        public async Task Update_ExistingResponse_ResponseUpdated()
        {
            // Arrange
            var responseRepositoryMock = new Mock<IResponseRepository>();
            var responseService = new ResponseService(responseRepositoryMock.Object);
            var existingResponse = new ResponseEntity
            {
                Id = 1,
                Content = "Existing content",
                DateTime = DateTime.UtcNow,
                Audience = "Existing audience"
            };
            responseRepositoryMock.Setup(repo => repo.GetByIdAsync(1))
                                  .ReturnsAsync(existingResponse);

            var updatedResponseModel = new ResponseModel
            {
                Id = 1,
                Content = "Updated content",
                DateTime = DateTime.UtcNow,
                Audience = "Updated audience"
            };

            // Act
            await responseService.Update(updatedResponseModel);

            // Assert
            responseRepositoryMock.Verify(repo => repo.Update(It.IsAny<ResponseEntity>()), Times.Once);
            Assert.AreEqual(updatedResponseModel.Content, existingResponse.Content);
            Assert.AreEqual(updatedResponseModel.DateTime, existingResponse.DateTime);
            Assert.AreEqual(updatedResponseModel.Audience, existingResponse.Audience);
        }

    }
}
