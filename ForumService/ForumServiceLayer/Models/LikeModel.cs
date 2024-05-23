namespace ForumServiceLayer.Models
{
    public class LikeModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int ResponseId { get; set; }
        public int UserId { get; set; }
    }
}
