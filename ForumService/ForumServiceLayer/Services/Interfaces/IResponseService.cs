using ForumServiceLayer.Models;

namespace ForumServiceLayer.Services.Interfaces
{
    public interface IResponseService
    {
        Task<ResponseModel> Create(ResponseModel p);
        Task Update(ResponseModel Response);
        Task Delete(ResponseModel Response);
        Task<ResponseModel> Get(int id);
        Task<List<ResponseModel>> GetAll(int postId);
    }
}
