﻿using DataProvider;
using Domain;
using Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Services
{
    public class PostsService: BaseCRUDService<Post, int>, IPostsService
    {
        public PostsService(UnitOfWork uow) : base(uow, uow.Posts)
        {
        }
    }
}
