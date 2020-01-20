using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;

namespace Recruitment.Data.EntitiesService.UpdateRepository
{
    public class UpdateRepository<T> : IUpdateRepository<T>, IBaseRepository<T> where T : class
    {
        #region Properties
        public DbContext DbContext { get; set; }
        public DbSet<T> DbSet { get; set; }
        #endregion
        #region Constructor
        public UpdateRepository(DbContext dbContext)
        {
            this.DbContext = dbContext;
            this.DbSet = DbContext.Set<T>();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Update a single object in database.
        /// </summary>
        /// <param name="entity"></param>
        public bool Update(T entity)
        {
            EntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
                DbSet.Attach(entity);
            dbEntityEntry.State = EntityState.Modified;
            return true;
        }
        /// <summary>
        /// Update a list of object in database.
        /// </summary>
        /// <param name="entityList"></param>
        public void Update(List<T> entityList)
        {
            foreach (T item in entityList)
                Update(item);
        }
        #endregion
    }
}
