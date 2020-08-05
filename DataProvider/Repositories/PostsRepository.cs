using DataProvider.Repositories.Abstractions;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider.Repositories
{
    public class PostsRepository : BaseRepository<Post, int>, IPostsRepository
    {
        public PostsRepository(AppContext dataContext) : base(dataContext)
        {
            
        }
    }
}
