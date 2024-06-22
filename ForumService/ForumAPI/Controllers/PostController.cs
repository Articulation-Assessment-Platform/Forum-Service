using ForumAPI.Dtos;
using ForumAPI.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ForumAPI.Models;
using ForumAPI.Services.Interfaces;

namespace ForumAPI.Controllers
{
    [Authorize(Roles = "SpeechTherapist")]
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("get/forum/{ForumId}")]
        public async Task<IActionResult> GetForumPosts(int ForumId)
        {
            List<PostModel> posts = await _postService.GetAll(ForumId);

            if (posts == null)
            {
                return BadRequest("No post found in this forum.");
            }

            return Ok(MapToDtoList(posts));
        }

        [HttpGet("get/user/{UserId}")]
        public async Task<IActionResult> GetUserPosts(int UserId)
        {
            List<PostModel> posts = await _postService.GetAllUser(UserId);

            if (posts == null)
            {
                return BadRequest("No post found for this user.");
            }

            return Ok(MapToDtoList(posts));
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddPost([FromBody] PostAddDto p)
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
            return Ok(MapToDto(postCreated));
        }

        [HttpDelete("delete/{postId}")]
        public IActionResult DeletePost(int postId)
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

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            PostModel post = await _postService.Get(id);

            if (post == null)
            {
                return BadRequest("No post found with this id.");
            }

            return Ok(MapToDto(post));
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

            return Ok(MapToDtoList(posts));
        }

        private static PostDto MapToDto(PostModel post)
        {
            return new PostDto
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                AuthorId = post.AuthorId,
                DateTime = post.DateTime,
                Audience = post.Audience,
                Url = post.Url,
                ForumId = post.ForumId
            };
        }

        private static List<PostDto> MapToDtoList(IEnumerable<PostModel> posts)
        {
            return posts.Select(p => MapToDto(p)).ToList();
        }
    }
}
