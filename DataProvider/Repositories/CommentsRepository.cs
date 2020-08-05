using DataProvider.Repositories.Abstractions;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider.Repositories
{
    public class CommentsRepository : BaseRepository<Comment, int>, ICommentsRepository
    {
        public CommentsRepository(AppContext dataContext) : base(dataContext)
        {
            
        }
    }
}
