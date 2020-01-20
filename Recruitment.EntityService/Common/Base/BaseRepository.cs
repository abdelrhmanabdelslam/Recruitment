using Recruitment.Data.EntitiesService.CreateRepository;
using Recruitment.Data.EntitiesService.DeleteRepository;
using Recruitment.Data.EntitiesService.ReadRepository;
using Recruitment.Data.EntitiesService.UpdateRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Recruitment.Data.EntitiesService.Base
{
    public class BaseRepository<T> : ICreateRepository<T>, IReadRepository<T>,IUpdateRepository<T>,IDeleteRepository<T> where T : class
    {
        #region Properties
        #region CRUD Properties
        private ICreateRepository<T> CreateRepository;
        private IUpdateRepository<T> UpdateRepository;
        private IDeleteRepository<T> DeleteRepository;
        private IReadRepository<T> ReadRepository;
        #endregion
        #endregion
        #region Constructor
        public BaseRepository(DbContext dbContext)
        {
            this.CreateRepository = new CreateRepository<T>(dbContext);
            this.UpdateRepository = new UpdateRepository<T>(dbContext);
            this.DeleteRepository = new DeleteRepository<T>(dbContext);
            this.ReadRepository = new ReadRepository<T>(dbContext);
        }
        #endregion
        #region CRUD - Methods
        #region Create
        public async Task<bool> Insert(T entity)
        {
            return await CreateRepository.Insert(entity);
        }
        public async Task Insert(List<T> entityList)
        {
            await CreateRepository.Insert(entityList);
        }
        public async Task BulkInsert(List<T> entityList)
        {
            await CreateRepository.BulkInsert(entityList);
        }
        #endregion
        #region Update
        public bool Update(T entity)
        {
            return UpdateRepository.Update(entity);
        }
        public void Update(List<T> entityList)
        {
            UpdateRepository.Update(entityList);
        }
        #endregion
        #region Delete
        public void Delete(T entity)
        {
            DeleteRepository.Delete(entity);
        }
        public void Delete(List<T> entityList)
        {
            DeleteRepository.Delete(entityList);
        }
        public void BulkDelete(Expression<Func<T, bool>> expression = null)
        {
            DeleteRepository.BulkDelete(expression);
        }
        #endregion
        #region Read
        public async Task<T> GetById(int entityId)
        {
            return await ReadRepository.GetById(entityId);
        }
        public async Task<T> GetById(long entityId)
        {
            return await ReadRepository.GetById(entityId);
        }
        public async Task<T> GetById(short entityId)
        {
            return await ReadRepository.GetById(entityId);
        }
        public IQueryable<T> GetAll()
        {
            return ReadRepository.GetAll();
        }
        public IQueryable<T> GetAllSorted<TKey>(Expression<Func<T, TKey>> sortingExpression)
        {
            return ReadRepository.GetAllSorted(sortingExpression);
        }
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter = null, string includeProperties = "")
        {
            return ReadRepository.GetWhere(filter, includeProperties);
        }

        public async  Task<T> GetById(byte entityId)
        {
            return await ReadRepository.GetById(entityId);

        }
        #endregion
        #endregion
    }
}
