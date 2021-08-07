using CleanArchitecture.Domain.BusinessEntities;

namespace CleanArchitecture.Application.Repositories
{
    public interface IUserRepositoryAsync : IGenericRepositoryAsync<User, long>
    {
    }
}
