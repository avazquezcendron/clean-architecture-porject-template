using AutoMapper;
using CleanArchitecture.Application.Contracts.DTOs;
using CleanArchitecture.Application.Contracts.Services;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.BusinessEntities;

namespace CleanArchitecture.Infrastructure.Persistence.Services
{
    public class UserService : GenericService<AddUserDTO, GetUserDTO, User, long, long>, IUserService
    {

        public UserService(IMapper mapper, IUserRepositoryAsync userRepository): base (mapper, userRepository)
        {
        }

    }
}
