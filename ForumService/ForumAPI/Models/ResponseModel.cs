namespace ForumAPI.Models
{
    public class ResponseModel
    {
        public int Id { get; set; }
        public required int AuthorId { get; set; }
        public string Content { get; set; } = string.Empty;
        public required int PostId { get; set; }
        public int ResponseId { get; set; }
        public string Audience { get; set; } = string.Empty;
        public required DateTime DateTime { get; set; }
        public string Url { get; set; } = string.Empty;
        public int Likes { get; set; }

    }
}
