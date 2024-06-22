using ForumAPI.Models;

namespace ForumAPI.Services.Interfaces
{
    public interface IResponseService
    {
        Task<ResponseModel> Create(ResponseModel p);
        Task Update(ResponseModel Response);
        void Delete(int id);
        Task<ResponseModel> Get(int id);
        Task<List<ResponseModel>> GetAll(int postId);
    }
}
