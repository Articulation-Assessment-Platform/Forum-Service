using ForumRepositoryLayer.Entities;

namespace ForumRepositoryLayer.Services.Interfaces
{
    public interface IResponseRepository : IBaseRepository<ResponseEntity>
    {
        Task<List<ResponseEntity>> GetByPostId(int PostId);
    }
}
