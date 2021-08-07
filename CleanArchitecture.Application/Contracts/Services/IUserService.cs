using CleanArchitecture.Application.Contracts.DTOs;

namespace CleanArchitecture.Application.Contracts.Services
{
    public interface IUserService: IGenericService<AddUserDTO, GetUserDTO, long>
    {

    }
}
