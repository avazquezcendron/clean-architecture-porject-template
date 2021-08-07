using CleanArchitecture.Application.Contracts.DTOs;
using CleanArchitecture.Application.Contracts.DTOs.Common;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Services
{
    public interface ITagService : IGenericService<AddTagDTO, GetTagDTO, long>
    {
        Task<ResponseValueDTO<GetTagWithStoriesDTO>> GetTagWithStoriesAsync(long tagId);
    }
}
