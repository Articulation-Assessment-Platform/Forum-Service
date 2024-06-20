using ForumServiceLayer.Models;

namespace ForumServiceLayer.Services.Interfaces
{
    public interface IResponseService
    {
        Task<ResponseModel> Create(ResponseModel p);
        Task Update(ResponseModel Response);
        Task Delete(int id);
        Task<ResponseModel> Get(int id);
        Task<List<ResponseModel>> GetAll(int postId);
    }
}
