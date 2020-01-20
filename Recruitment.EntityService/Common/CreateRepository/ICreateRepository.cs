using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recruitment.Data.EntitiesService.CreateRepository
{
    public interface ICreateRepository<T> where T : class
    {
        #region Create
        Task<bool> Insert(T entity);
        Task Insert(List<T> entityList);
        Task BulkInsert(List<T> entityList);
        #endregion
    }
}
