﻿namespace ForumAPI.Dtos
{
    public class LikeDto
    {
        public required int Id { get; set; }
        public required int PostId { get; set; }
        public required int ResponseId { get; set; }
        public required int UserId { get; set; }
    }
}
