﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Services.Interfaces;
using ForumServiceLayer.Models;
using ForumServiceLayer.Services.Interfaces;

namespace ForumServiceLayer.Services
{
    public class ResponseService : IResponseService
    {
        private readonly IResponseRepository _responseRepository;

        public ResponseService(IResponseRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }

        public async Task<ResponseModel> Create(ResponseModel p)
        {
            if (p == null)
            {
                throw new ArgumentException("Response cannot be null.");
            }

            ResponseEntity responseEntity = new ResponseEntity()
            {
                Content = p.Content,
                AuthorId = p.AuthorId,
                DateTime = p.DateTime,
                Audience = p.Audience,
                Url = p.Url,
                ResponseId = p.ResponseId
            };

            ResponseEntity createdResponseEntity = await _responseRepository.AddAsync(responseEntity);
            return TransformBack(createdResponseEntity);
        }

        public async Task Update(ResponseModel Response)
        {
            if (Response == null)
            {
                throw new ArgumentException("Response cannot be null.");
            }

            ResponseEntity existingResponse = await _responseRepository.GetByIdAsync((int)Response.Id);
            if (existingResponse != null)
            {
                existingResponse.Content = Response.Content;
                existingResponse.DateTime = Response.DateTime;
                existingResponse.Audience = Response.Audience;

                _responseRepository.Update(existingResponse);
            }
            else
            {
                throw new ArgumentException("There is no response found to update.");
            }
        }

        public async Task Delete(ResponseModel Response)
        {
            if (Response == null)
            {
                throw new ArgumentException("Response cannot be null.");
            }

            ResponseEntity existingResponse = await _responseRepository.GetByIdAsync((int)Response.Id);
            if (existingResponse != null)
            {
                _responseRepository.Remove(existingResponse);
            }
            else
            {
                throw new ArgumentException("There is no Response with this information.");
            }
        }

        public async Task<ResponseModel> Get(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid response ID.");
            }

            ResponseEntity ResponseEntity = await _responseRepository.GetByIdAsync(id);
            if (ResponseEntity == null)
            {
                throw new ArgumentException("Response not found.");
            }

            return TransformBack(ResponseEntity);
        }

        private ResponseModel TransformBack(ResponseEntity r)
        {
            return new ResponseModel()
            {
                Id = r.Id,
                Content = r.Content,
                AuthorId = r.AuthorId,
                DateTime = r.DateTime,
                Audience = r.Audience,
                Url = r.Url,
                ResponseId = r.ResponseId,
                PostId = r.PostId
            };
        }

        public async Task<List<ResponseModel>> GetAll(int postId)
        {
            if (postId <= 0)
            {
                throw new ArgumentException("Invalid post ID.");
            }

            List<ResponseEntity> Responses = await _responseRepository.GetByPostId(postId);

            List<ResponseModel> ResponseModels = new List<ResponseModel>();
            foreach (ResponseEntity r in Responses)
            {
                ResponseModels.Add(new ResponseModel()
                {
                    Id = r.Id,
                    Content = r.Content,
                    AuthorId = r.AuthorId,
                    DateTime = r.DateTime,
                    Audience = r.Audience,
                    Url = r.Url,
                    ResponseId = r.ResponseId,
                    PostId = r.PostId
                });
            }

            return ResponseModels;
        }
    }
}
