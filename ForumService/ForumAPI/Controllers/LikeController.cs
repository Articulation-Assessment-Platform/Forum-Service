﻿using ForumAPI.DTOs;
using ForumServiceLayer.Models;
using ForumServiceLayer.Services;
using ForumServiceLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace ForumAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class LikeController : Controller
    {
        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }

        [HttpGet("getPostLikes/{postId}")]
        public async Task<IActionResult> GetPostLikes(int postId)
        {
            List<LikeModel> likesModel = await _likeService.GetAllPost(postId);
            List<LikeDTO> ls = new List<LikeDTO>();
            if(likesModel.Count == 0) { return Ok("No likes for this post yet."); }
            foreach (LikeModel l in likesModel)
            {
                ls.Add(new LikeDTO()
                {
                    Id = l.Id,
                    UserId = l.UserId,
                    PostId = l.PostId

                });
            }
            return Ok(ls);
        }
        [HttpGet("getResponseLikes/{responseId}")]
        public async Task<IActionResult> GetResponseLikes(int responseId)
        {
            List<LikeModel> likesModel = await _likeService.GetAllResponse(responseId);
            List<LikeDTO> ls = new List<LikeDTO>();
            if (likesModel.Count == 0) { return Ok("No likes for this response yet."); }
            foreach (LikeModel l in likesModel)
            {
                ls.Add(new LikeDTO()
                {
                    Id = l.Id,
                    UserId = l.UserId,
                    ResponseId = l.ResponseId,
                    PostId = l.PostId

                });
            }
            return Ok(ls);
        }
        [HttpGet("getUserLikes/{userId}")]
        public async Task<IActionResult> GetUserLikes(int userId)
        {
            List<LikeModel> likesModel = await _likeService.GetAllUser(userId);
            List<LikeDTO> ls = new List<LikeDTO>();
            if (likesModel.Count == 0) { return Ok("You have not liked anything user yet."); }
            foreach (LikeModel l in likesModel)
            {
                ls.Add(new LikeDTO()
                {
                    Id = l.Id,
                    UserId = l.UserId,
                    PostId = l.PostId,
                    ResponseId = l.ResponseId
                });
            }
            return Ok(ls);
        }

        //add
        [HttpPost("like")]
        public IActionResult Like([FromBody] LikeDTO l)
        {
            LikeModel like = new LikeModel
            {
                PostId = l.PostId,
                UserId = l.UserId,
                ResponseId = l.ResponseId
            };
            _likeService.Create(like);
            return Ok();
        }


        //delete
        [HttpDelete("unlike")]
        public IActionResult UnLike([FromBody] LikeDTO l)
        {
            LikeModel like = new LikeModel
            {
                Id=l.Id,
                PostId = l.PostId,
                UserId = l.UserId,
                ResponseId = l.ResponseId
            };
            _likeService.Delete(like);
            return Ok();
        }
    }
}
