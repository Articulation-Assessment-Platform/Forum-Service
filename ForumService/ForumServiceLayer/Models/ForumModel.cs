﻿namespace ForumServiceLayer.Models
{
    public class ForumModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null;
        public string Description { get; set; } = null;
        public string Audience { get; set; } = null;
    }
}
