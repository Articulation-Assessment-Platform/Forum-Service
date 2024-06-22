namespace ForumAPI.DTOs
{
    public class PostAddDto
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public required int AuthorId { get; set; }
        public string Audience { get; set; } = string.Empty;
        public required DateTime DateTime { get; set; }
        public string Url { get; set; } = string.Empty;
        public required int ForumId { get; set; }
    }
}
