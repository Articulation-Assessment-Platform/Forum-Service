using RepositoryLayer.Entities;

namespace RepositoryLayer.Services.Interfaces
{
    public interface IResponseRepository : IBaseRepository<ResponseEntity>
    {
        Task<List<ResponseEntity>> GetByPostId(int PostId);
    }
}
