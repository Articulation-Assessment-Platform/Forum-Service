using ForumServiceLayer.Models;
using ForumServiceLayer.Services.Interfaces;

namespace ForumRepositoryLayer.Repositories
{
    public class ResponseRepository : IBaseRepository<ResponseModel>, IResponseRepository
    {
        public Task<ResponseModel> AddAsync(ResponseModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ResponseModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ResponseModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
