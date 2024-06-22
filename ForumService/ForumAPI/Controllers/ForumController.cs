using ForumAPI.Dtos;
using ServiceLayer.Models;
using ServiceLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Security.Principal;

namespace ForumAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForumController : ControllerBase
    {
        private readonly IforumService _forumService;
        public ForumController(IforumService forumService)
        {
            _forumService = forumService;
        }

        //Get all public forums 
        [HttpGet("forums/public")]
        public async Task<IActionResult> GetAllPublicForums()
        {
            List<ForumModel> forums = await _forumService.GetForums("None");
            

            if (forums == null) return BadRequest("No forums found.");

            List<ForumDto> frms = new List<ForumDto>();

            foreach (ForumModel forum in forums)
            {

                frms.Add(new ForumDto
                {
                    Id = forum.Id,
                    Audience = forum.Audience,
                    CategoryName = forum.CategoryName,
                    Description = forum.Description
                });
            }
            return Ok(frms);
        }
        [Authorize]
        [HttpGet("forums/{audience}")]
        public async Task<IActionResult> GetAllAuthorisedForums(string audience)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;    
            var roleClaim = identity.FindFirst(ClaimTypes.Role);

            if (roleClaim.Value != audience)
            {
                return Unauthorized("Unauthorized to check out this forum.");
            }

            List<ForumModel> forums = await _forumService.GetForums(roleClaim.Value);

            if (forums == null) return BadRequest("No forums found.");

            List<ForumDto> frms = new List<ForumDto>();

            foreach (ForumModel forum in forums)
            {
                frms.Add(new ForumDto
                {
                    Id = forum.Id,
                    Audience = forum.Audience,
                    CategoryName = forum.CategoryName,
                    Description = forum.Description
                });
            }
            return Ok(frms);
        }
    }
}
