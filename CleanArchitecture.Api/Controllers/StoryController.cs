using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using CleanArchitecture.Application.Contracts.DTOs;
using CleanArchitecture.Application.Contracts.DTOs.Common;
using CleanArchitecture.Application.Contracts.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Controllers
{
    public class StoriesController : GenericController<AddStoryDTO, GetStoryDTO, long>
    {

        public StoriesController(IStoryService storyService) : base(storyService)
        {
        }

        // GET: api/stories/tags
        [HttpGet("tags")]
        public async Task<IActionResult> GetStoriesByTag([FromQuery] long? tagId)
        {
            if (tagId.GetValueOrDefault() > 0)
            {
                var responseDTO = await (this._service as IStoryService).GetStoriesByTag(tagId.GetValueOrDefault());
                return Ok(responseDTO);
            }

            return BadRequest();
        }

        // GET: api/stories/title
        [HttpGet("title")]
        public async Task<IActionResult> GetStoriesByTitle([FromQuery] string title)
        {
            var responseDTO = await (this._service as IStoryService).GetStoriesByTitle(title);
            return Ok(responseDTO);
        }
    }
}
