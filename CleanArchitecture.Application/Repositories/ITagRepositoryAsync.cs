using CleanArchitecture.Domain.BusinessEntities;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Repositories
{
    public interface ITagRepositoryAsync : IGenericRepositoryAsync<Tag, long>
    {
        Task<Tag> GetTagWithStoriesAsync(long tagId);
    }
}
