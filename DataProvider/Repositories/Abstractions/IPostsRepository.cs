using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider.Repositories.Abstractions
{
    public interface IPostsRepository : IRepository<Post, int>
    {
    }
}
