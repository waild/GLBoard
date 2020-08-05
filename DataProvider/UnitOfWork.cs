using System;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Text;
using DataProvider.Repositories;
using DataProvider.Repositories.Abstractions;
using DataProvider.Abstractions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataProvider
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppContext context;

        private IDbContextTransaction _transaction;

        public UnitOfWork(AppContext context)
        {
            this.context = context;

            this.Posts = new PostsRepository(this.context);
            this.Users = new UsersRepository(this.context);
            this.Comments = new CommentsRepository(this.context);
        }

        public IPostsRepository Posts { get; }
        public IUsersRepository Users { get; }
        public ICommentsRepository Comments { get; }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }


        public void BeginTransaction()
        {
            _transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                context.SaveChanges();
                _transaction.Commit();
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
       
    }
}
