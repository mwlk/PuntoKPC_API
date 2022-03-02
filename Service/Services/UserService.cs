using Interface.Interfaces;
using Persistence.Data;
using Persistence.Models;
using Repository;

namespace Service.Services
{
    public class UserService: EntityBaseRepository<Usuario>, IUserService
    {
        public UserService(EcommerceContext context) : base(context)
        {

        }
        
    }
}
