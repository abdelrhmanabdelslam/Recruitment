using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Data.EntitiesService.CreateRepository
{
    public class CreateRepository<T> : IBaseRepository<T>, ICreateRepository<T> where T : class
    {
        #region Properties
        public DbContext DbContext { get; set; }
        public DbSet<T> DbSet { get; set; }
        #endregion
        #region Constructor
        public CreateRepository(DbContext dbContext)
        {
            this.DbContext = dbContext;
            this.DbSet = DbContext.Set<T>();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Insert a single object into the database.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>bool</returns>
        public async Task<bool> Insert(T entity)
        {
            EntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
                dbEntityEntry.State = EntityState.Added;
            else
                await DbSet.AddAsync(entity);
            return true;
        }
        /// <summary>
        /// Insert a list of objects into the database.
        /// </summary>
        /// <param name="entityList"></param>
        public async Task Insert(List<T> entityList)
        {
            foreach (T item in entityList)
                await Insert(item);
        }
        /// <summary>
        /// Insert a list of objects into the database as Bulk.
        /// </summary>
        /// <param name="entityList"></param>
        public async Task BulkInsert(List<T> entityList)
        {
            await DbSet.AddRangeAsync(entityList);
        }
        #endregion
    }
}
