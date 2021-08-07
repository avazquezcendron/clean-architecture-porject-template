using CleanArchitecture.Application.Contracts.DTOs.Common;
using CleanArchitecture.Domain.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Repositories
{
    public interface IGenericRepositoryAsync<T, TId> where T : IBusinessEntity<TId>
    {
        Task<T> GetByIdAsync(TId id);
        Task<IEnumerable<T>> GetAllAsync(IRequestPaginationDTO requestPaginationDTO);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
