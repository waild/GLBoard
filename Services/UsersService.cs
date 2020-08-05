using DataProvider;
using Domain;
using Services.Abstraction;

namespace Services
{
    public class UsersService: BaseCRUDService<User, string>, IUsersService
    {
        public UsersService(UnitOfWork uow) : base(uow, uow.Users)
        {
        }
    }
}
