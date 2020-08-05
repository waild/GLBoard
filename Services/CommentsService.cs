using DataProvider;
using Domain;
using Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Services
{
    public class CommentsService: BaseCRUDService<Comment, int>, ICommentsService
    {
        private readonly UnitOfWork uow;

        public CommentsService(UnitOfWork uow) : base(uow, uow.Comments)
        {
        }
    }
}
