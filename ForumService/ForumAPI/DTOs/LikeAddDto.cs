namespace ForumAPI.DTOs
{
    public class LikeAddDto
    {
        public required int PostId { get; set; }
        public required int ResponseId { get; set; }
        public required int UserId { get; set; }
    }
}
