using CleanArchitecture.Domain.BusinessEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Repositories
{
    public interface IStoryRepositoryAsync : IGenericRepositoryAsync<Story, long>
    {
        Task<IEnumerable<Story>> GetStoriesByTag(long tagId);
        Task<IEnumerable<Story>> GetStoriesByTitle(string title);
    }
}
