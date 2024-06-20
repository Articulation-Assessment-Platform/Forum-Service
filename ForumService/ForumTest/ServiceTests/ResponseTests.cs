using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Services.Interfaces;
using ForumServiceLayer.Models;
using ForumServiceLayer.Services;
using Moq;

namespace ForumTest.ServiceTests
{
    [TestClass]
    public class ResponseTests
    {
        private Mock<IResponseRepository> _responseRepositoryMock;
        private ResponseService _responseService;

        [TestInitialize]
        public void SetUp()
        {
            _responseRepositoryMock = new Mock<IResponseRepository>();
            _responseService = new ResponseService(_responseRepositoryMock.Object);
        }

        [TestMethod]
        public async Task Create_NullResponse_ThrowsArgumentException()
        {
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _responseService.Create(null));
            Assert.AreEqual("Response cannot be null.", exception.Message);
        }

        [TestMethod]
        public async Task Create_ValidResponse_ReturnsResponseModel()
        {
            var responseModel = new ResponseModel { Content = "Test", AuthorId = 1, DateTime = DateTime.Now, Audience = "General", Url = "http://example.com", ResponseId = 1, PostId=1 };
            var responseEntity = new ResponseEntity { Id = 1, Content = "Test", AuthorId = 1, DateTime = DateTime.Now, Audience = "General", Url = "http://example.com", ResponseId = 1 };

            _responseRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<ResponseEntity>())).ReturnsAsync(responseEntity);

            var result = await _responseService.Create(responseModel);

            Assert.IsNotNull(result);
            Assert.AreEqual(responseModel.Content, result.Content);
            _responseRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<ResponseEntity>()), Times.Once);
        }

        [TestMethod]
        public async Task Update_NullResponse_ThrowsArgumentException()
        {
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _responseService.Update(null));
            Assert.AreEqual("Response cannot be null.", exception.Message);
        }

        [TestMethod]
        public async Task Update_ResponseNotFound_ThrowsArgumentException()
        {
            var responseModel = new ResponseModel { Id = 1, Content = "Test", AuthorId = 1, DateTime = DateTime.Today, PostId = 1 };

            _responseRepositoryMock.Setup(repo => repo.GetByIdAsync((int)responseModel.Id)).ReturnsAsync((ResponseEntity)null);

            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _responseService.Update(responseModel));
            Assert.AreEqual("There is no response found to update.", exception.Message);
        }

        [TestMethod]
        public async Task Update_ValidResponse_UpdatesResponse()
        {
            var responseModel = new ResponseModel { Id = 1, Content = "Test", DateTime = DateTime.Now, Audience = "General", AuthorId=1, PostId=1 };
            var responseEntity = new ResponseEntity { Id = 1, Content = "Test", DateTime = DateTime.Now, Audience = "General" };

            _responseRepositoryMock.Setup(repo => repo.GetByIdAsync((int)responseModel.Id)).ReturnsAsync(responseEntity);

            await _responseService.Update(responseModel);

            _responseRepositoryMock.Verify(repo => repo.Update(It.IsAny<ResponseEntity>()), Times.Once);
        }

        [TestMethod]
        public async Task Delete_NullResponse_ThrowsArgumentException()
        {
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _responseService.Delete(null));
            Assert.AreEqual("Response cannot be null.", exception.Message);
        }

        [TestMethod]
        public async Task Delete_ResponseNotFound_ThrowsArgumentException()
        {
            var responseModel = new ResponseModel { Id = 1, Content = "Test", DateTime = DateTime.Now, Audience = "General", AuthorId = 1, PostId = 1 };

            _responseRepositoryMock.Setup(repo => repo.GetByIdAsync((int)responseModel.Id)).ReturnsAsync((ResponseEntity)null);

            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _responseService.Delete(responseModel));
            Assert.AreEqual("There is no Response with this information.", exception.Message);
        }

        [TestMethod]
        public async Task Delete_ValidResponse_DeletesResponse()
        {
            var responseModel = new ResponseModel { Id = 1, Content = "Test", DateTime = DateTime.Now, Audience = "General", AuthorId = 1, PostId = 1 };
            var responseEntity = new ResponseEntity { Id = 1 };

            _responseRepositoryMock.Setup(repo => repo.GetByIdAsync((int)responseModel.Id)).ReturnsAsync(responseEntity);

            await _responseService.Delete(responseModel);

            _responseRepositoryMock.Verify(repo => repo.Remove(It.IsAny<ResponseEntity>()), Times.Once);
        }

        [TestMethod]
        public async Task Get_InvalidId_ThrowsArgumentException()
        {
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _responseService.Get(0));
            Assert.AreEqual("Invalid response ID.", exception.Message);
        }

        [TestMethod]
        public async Task Get_ResponseNotFound_ThrowsArgumentException()
        {
            _responseRepositoryMock.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((ResponseEntity)null);

            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _responseService.Get(1));
            Assert.AreEqual("Response not found.", exception.Message);
        }

        [TestMethod]
        public async Task Get_ValidId_ReturnsResponseModel()
        {
            var responseEntity = new ResponseEntity { Id = 1, Content = "Test", AuthorId = 1, DateTime = DateTime.Now, Audience = "General", Url = "http://example.com", ResponseId = 1 };

            _responseRepositoryMock.Setup(repo => repo.GetByIdAsync(responseEntity.Id)).ReturnsAsync(responseEntity);

            var result = await _responseService.Get(responseEntity.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(responseEntity.Content, result.Content);
            _responseRepositoryMock.Verify(repo => repo.GetByIdAsync(responseEntity.Id), Times.Once);
        }

        [TestMethod]
        public async Task GetAll_InvalidPostId_ThrowsArgumentException()
        {
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await _responseService.GetAll(0));
            Assert.AreEqual("Invalid post ID.", exception.Message);
        }

        [TestMethod]
        public async Task GetAll_ValidPostId_ReturnsResponseModels()
        {
            var responseEntities = new List<ResponseEntity>
            {
                new ResponseEntity { Id = 1, Content = "Test1", AuthorId = 1, DateTime = DateTime.Now, Audience = "General", Url = "http://example.com", ResponseId = 1 },
                new ResponseEntity { Id = 2, Content = "Test2", AuthorId = 2, DateTime = DateTime.Now, Audience = "General", Url = "http://example.com", ResponseId = 2 }
            };

            _responseRepositoryMock.Setup(repo => repo.GetByPostId(1)).ReturnsAsync(responseEntities);

            var result = await _responseService.GetAll(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            _responseRepositoryMock.Verify(repo => repo.GetByPostId(1), Times.Once);
        }
    }
}
