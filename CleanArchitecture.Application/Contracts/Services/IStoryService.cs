using CleanArchitecture.Application.Contracts.DTOs;
using CleanArchitecture.Application.Contracts.DTOs.Common;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Services
{
    public interface IStoryService : IGenericService<AddStoryDTO, GetStoryDTO, long>
    {
        Task<ResponseListDTO<GetStoryDTO>> GetStoriesByTag(long tagId);
        Task<ResponseListDTO<GetStoryDTO>> GetStoriesByTitle(string title);
    }
}
