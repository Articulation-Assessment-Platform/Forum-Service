using ForumAPI.Entities;

namespace ForumAPI.Services.Interfaces
{
    public interface IResponseRepository : IBaseRepository<ResponseEntity>
    {
        Task<List<ResponseEntity>> GetByPostId(int PostId);
    }
}
