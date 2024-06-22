using ForumAPI.DTOs;
using ServiceLayer.Models;
using ServiceLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ForumAPI.Controllers
{
    [Authorize(Roles = "SpeechTherapist")]
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
        [HttpGet("get/forum/{ForumId}")]
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

        [HttpGet("get/user/{UserId}")]
        public async Task<IActionResult> GetUserPosts(int UserId)
        {
            List<PostModel> posts = await _postService.GetAllUser(UserId);

            if (posts == null)
            {
                return BadRequest("No post found for this user.");
            }

            List<PostDTO> ps = new List<PostDTO>();
            foreach (PostModel p in posts)
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
        public async Task<IActionResult> AddPost([FromBody] PostDTO p)
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
            PostModel postCreated = await _postService.Create(post);
            return Ok(postCreated);
        }


        //delete
        [HttpDelete("delete/{postId}")]
        public async Task<IActionResult> DeletePost(int postId)
        {
            try
            {
                _postService.Delete(postId);

                return Ok(); 
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (log, return StatusCode, etc.)
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
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
        [HttpGet("get/publicforum")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicForumPosts()
        {
            List<PostModel> posts = await _postService.GetAll(2);

            if (posts == null)
            {
                return BadRequest("No post found in this forum.");
            }

            List<PostDTO> ps = new List<PostDTO>();
            foreach (PostModel p in posts)
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

    }
}
