using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Data.EntitiesService.ReadRepository
{
    public class ReadRepository<T> : IReadRepository<T>, IBaseRepository<T> where T : class
    {
        #region Properties
        public DbContext DbContext { get; set; }
        public DbSet<T> DbSet { get; set; }
        #endregion
        #region Constructor
        public ReadRepository(DbContext dbContext)
        {
            this.DbContext = dbContext;
            this.DbSet = DbContext.Set<T>();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Getting a single object by int Id
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns>T</returns>
        public async Task<T> GetById(int entityId)
        {
            return await DbSet.FindAsync(entityId);
        }
        /// <summary>
        /// Getting a single object by long Id
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns>T</returns>
        public async Task<T> GetById(long entityId)
        {
            return await DbSet.FindAsync(entityId);
        }
        /// <summary>
        /// Getting a single object by short Id
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns>T</returns>
        public async Task<T> GetById(short entityId)
        {
            return await DbSet.FindAsync(entityId);
        }
        /// <summary>
        /// Getting all data.
        /// </summary>
        /// <returns>IQueryable<T></returns>
        public virtual IQueryable<T> GetAll()
        {
            return DbSet;
        }
        /// <summary>
        /// Getting all data sorted by specific key Ascending.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="sortingExpression"></param>
        /// <returns>IQueryable<T></returns>
        public IQueryable<T> GetAllSorted<TKey>(Expression<Func<T, TKey>> sortingExpression)
        {
            return DbSet.OrderBy(sortingExpression);
        }
        /// <summary>
        /// Getting a set of data by given condition.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includeProperties"></param>
        /// <returns>IQueryable<T></returns>
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter = null, string includeProperties = "")
        {
            IQueryable<T> query = DbSet;
            if (filter != null)
                query = query.Where(filter);
            query =
                includeProperties.
                Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }

        public async Task<T> GetById(byte entityId)
        {
            return await DbSet.FindAsync(entityId);
        }
        #endregion
    }
}
