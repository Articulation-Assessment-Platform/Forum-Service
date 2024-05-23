namespace ForumServiceLayer.Models
{
    public class ResponseModel
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Content { get; set; } = null;
        public int PostId { get; set; }
        public int ResponseId { get; set; }
        public string Audience { get; set; } = null;
        public DateTime DateTime { get; set; }
        public string Url { get; set; } = null;
        public int Likes { get; set; }

    }
}
