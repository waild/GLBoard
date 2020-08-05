using DataProvider.Repositories.Abstractions;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider.Repositories
{
    public class UsersRepository : BaseRepository<User, string>, IUsersRepository
    {
        public UsersRepository(AppContext dataContext) : base(dataContext)
        {
            
        }
    }
}
