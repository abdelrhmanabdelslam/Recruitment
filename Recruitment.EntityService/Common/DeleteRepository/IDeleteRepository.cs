using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Data.EntitiesService.DeleteRepository
{
    public interface IDeleteRepository<T> where T : class
    {
        #region Delete
        void Delete(T entity);
        void Delete(List<T> entityList);
        void BulkDelete(Expression<Func<T, bool>> expression = null);
        #endregion
    }
}
