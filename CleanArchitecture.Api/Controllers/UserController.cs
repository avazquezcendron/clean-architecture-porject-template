using CleanArchitecture.Application.Contracts.DTOs;
using CleanArchitecture.Application.Contracts.Services;

namespace CleanArchitecture.Controllers
{
    public class UsersController : GenericController<AddUserDTO, GetUserDTO, long>
    {

        public UsersController(IUserService userService): base(userService)
        {
        }

    }
}
