using ForumAPI.DTOs;
using ForumServiceLayer.Models;
using ForumServiceLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ForumAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        //View all(forum)
        [HttpGet("get/{ForumId}")]
        public async Task<IActionResult> GetForumPosts(int ForumId)
        {
            List<PostModel> posts = await _postService.GetAll(ForumId);

            if (posts == null)
            {
                return BadRequest("No post found in this forum.");
            }

            List<PostDTO> ps = new List<PostDTO>();
            foreach(PostModel p in posts)
            {
                ps.Add(new PostDTO()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                    AuthorId = p.AuthorId,
                    DateTime = p.DateTime,
                    Audience = p.Audience,
                    Url = p.Url,
                    ForumId = p.ForumId
                });
            }
            

            return Ok(ps);
        }

        //add
        [HttpPost("add")]
        public IActionResult AddPost([FromBody] PostDTO p)
        {
            PostModel post = new PostModel
            {
                Title = p.Title,
                Content = p.Content,
                AuthorId = p.AuthorId,
                Audience = p.Audience,
                DateTime = p.DateTime,
                Url = p.Url,
                ForumId = p.ForumId
                
            };
            _postService.Create(post);
            return Ok();
        }


        //delete
        [HttpDelete("delete")]
        public IActionResult DeletePost([FromBody] PostDTO p)
        {
            PostModel post = new PostModel
            {
                Id = p.Id,
                Title = p.Title,
                Content = p.Content,
                AuthorId = p.AuthorId,

            };
            _postService.Delete(post);
            return Ok();
        }

        //get 
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            PostModel p = await _postService.Get(id);

            if (p == null)
            {
                return BadRequest("No post found with this id.");
            }

            PostDTO post = new PostDTO()
            {
                Id = p.Id,
                Title = p.Title,
                Content = p.Content,
                AuthorId = p.AuthorId,
                DateTime = p.DateTime,
                Audience = p.Audience,
                Url = p.Url,
                ForumId =p.ForumId
            };

            return Ok(post);
        }


    }
}
