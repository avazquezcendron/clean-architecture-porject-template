using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.BusinessEntities
{
    public class User : AbstractBusinessEntity<long>
    {
        public User()
        {
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
