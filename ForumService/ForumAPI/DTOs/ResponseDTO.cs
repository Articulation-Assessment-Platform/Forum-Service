﻿using ForumAPI.Entities;
using System.Reflection.Metadata;

namespace ForumAPI.Dtos
{
    public class ResponseDto
    {
        public required int Id { get; set; }
        public required int AuthorId { get; set; }
        public string Content { get; set; } = string.Empty;
        public required int PostId { get; set; }
        public required int ResponseId { get; set; }
        public string Audience { get; set; } = string.Empty;
        public required DateTime DateTime { get; set; }  
        public string Url { get; set; } = string.Empty;
    }
}
