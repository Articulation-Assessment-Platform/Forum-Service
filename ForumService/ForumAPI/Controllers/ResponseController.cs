using ForumAPI.Dtos;
using ServiceLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ForumAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ResponseController : ControllerBase
    {
        private readonly IResponseService _responseService;
        public ResponseController(IResponseService responseService)
        {
            _responseService = responseService;
        }

        //View all(forum)
        [HttpGet("get/post/{responseId}")]
        public async Task<IActionResult> GetPostResponses(int responseId)
        {
            List<ResponseModel> responses = await _responseService.GetAll(responseId);

            if (responses == null)
            {
                return BadRequest("No response found in this forum.");
            }

            List<ResponseDto> ps = new List<ResponseDto>();
            foreach (ResponseModel p in responses)
            {
                ps.Add(new ResponseDto()
                {
                    Id = p.Id,
                    Content = p.Content,
                    AuthorId = p.AuthorId,
                    DateTime = p.DateTime,
                    Audience = p.Audience,
                    Url = p.Url,
                    PostId = p.PostId,
                    ResponseId = p.ResponseId
                });
            }


            return Ok(ps);
        }

        //add
        [HttpPost("add")]
        public IActionResult AddResponse([FromBody] ResponseDto p)
        {
            ResponseModel response = new ResponseModel
            {
                Id = p.Id,
                Content = p.Content,
                AuthorId = p.AuthorId,
                DateTime = p.DateTime,
                Audience = p.Audience,
                Url = p.Url,
                PostId = p.PostId,
                ResponseId = p.ResponseId

            };
            _responseService.Create(response);
            return Ok();
        }


        //delete
        [HttpDelete("delete")]
        public IActionResult DeleteResponse([FromBody] ResponseDto p)
        {
            ResponseModel response = new ResponseModel
            {
                Id = p.Id,
                Content = p.Content,
                AuthorId = p.AuthorId,
                DateTime = p.DateTime,
                Audience = p.Audience,
                Url = p.Url,
                PostId = p.PostId,
                ResponseId = p.ResponseId
            };
            _responseService.Delete(response.Id);
            return Ok();
        }

        //get 
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetResponse(int id)
        {
            ResponseModel p = await _responseService.Get(id);

            if (p == null)
            {
                return BadRequest("No response found with this id.");
            }

            ResponseDto response = new ResponseDto()
            {
                Id = p.Id,
                Content = p.Content,
                AuthorId = p.AuthorId,
                DateTime = p.DateTime,
                Audience = p.Audience,
                Url = p.Url,
                PostId = p.PostId,
                ResponseId = p.ResponseId
            };

            return Ok(response);
        }

    }
}
