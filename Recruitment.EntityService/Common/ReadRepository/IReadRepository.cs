using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Data.EntitiesService.ReadRepository
{
    public interface IReadRepository<T> where T : class
    {
        #region Retrieve
        Task<T> GetById(int entityId);
        Task<T> GetById(long entityId);
        Task<T> GetById(short entityId);
        Task<T> GetById(byte entityId);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllSorted<TKey>(Expression<Func<T, TKey>> sortingExpression);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> filter = null, string includeProperties = "");
        #endregion
    }
}
