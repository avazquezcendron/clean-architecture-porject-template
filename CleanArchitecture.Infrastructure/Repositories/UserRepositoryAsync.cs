using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.BusinessEntities;
using CleanArchitecture.Infrastructure.Persistence.Contexts;

namespace CleanArchitecture.Infrastructure.Persistence.Repositories
{
    public class UserRepositoryAsync : GenericRepositoryAsync<User, long>, IUserRepositoryAsync
    {
        public UserRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
