using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider.Repositories.Abstractions
{
    public interface ICommentsRepository : IRepository<Comment, int>
    {
    }
}
