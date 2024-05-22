namespace ForumRepositoryLayer.Entities
{
    public class ForumEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<PostEntity> Posts { get; set; }
        public Audience Audience { get; set; }
    }
}
