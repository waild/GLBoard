using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider.Repositories.Abstractions
{
    public interface IUsersRepository : IRepository<User, string>
    {
    }
}
