using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.Contracts.DTOs;
using CleanArchitecture.Application.Contracts.Services;
using System.Threading.Tasks;

namespace CleanArchitecture.Controllers
{
    public class TagsController : GenericController<AddTagDTO, GetTagDTO, long>
    {

        public TagsController(ITagService tagService) : base(tagService)
        {
        }

        // GET: api/tags/{id}/stories
        [HttpGet]
        [Route("{id}/stories")]
        public async Task<IActionResult> GetStoriesByTag(long? id)
        {
            if (id.GetValueOrDefault() > 0)
            {
                var responseDTO = await (this._service as ITagService).GetTagWithStoriesAsync(id.GetValueOrDefault());
                return Ok(responseDTO);
            }

            return BadRequest();
        }
    }
}
