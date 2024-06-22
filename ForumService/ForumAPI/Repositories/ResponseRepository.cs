﻿using ForumAPI.Entities;
using ForumAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ForumAPI.Repositories
{
    public class ResponseRepository : BaseRepository<ResponseEntity>, IResponseRepository
    {
        private new readonly ForumContext _context;
        public ResponseRepository(ForumContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ResponseEntity>> GetByPostId(int PostId)
        {
            List<ResponseEntity> responses = await _context.Set<ResponseEntity>()
                .Where(e => e.PostId == PostId)
                .ToListAsync();

            return responses;
        }
    }
}
