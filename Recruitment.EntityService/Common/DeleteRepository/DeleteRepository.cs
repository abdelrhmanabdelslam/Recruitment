using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Recruitment.Data.EntitiesService.DeleteRepository
{
    public class DeleteRepository<T> : IDeleteRepository<T>, IBaseRepository<T> where T : class
    {
        #region Properties
        public DbContext DbContext { get; set; }
        public DbSet<T> DbSet { get; set; }
        #endregion
        #region Constructor
        public DeleteRepository(DbContext dbContext)
        {
            this.DbContext = dbContext;
            this.DbSet = DbContext.Set<T>();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Delete single object from database.
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            EntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }
        }
        /// <summary>
        /// Delete list of objects from database.
        /// </summary>
        /// <param name="entityList"></param>
        public void Delete(List<T> entityList)
        {
            foreach (T item in entityList)
                Delete(item);
        }

        public void BulkDelete(Expression<Func<T, bool>> expression = null)
        {
            this.DbSet.RemoveRange(DbSet.Where(expression));
        }
        #endregion
    }
}
