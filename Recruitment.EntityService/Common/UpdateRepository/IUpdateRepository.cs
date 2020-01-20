using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Data.EntitiesService.UpdateRepository
{
    public interface IUpdateRepository<T> where T : class
    {
        #region Update
        bool Update(T entity);
        void Update(List<T> entityList);
        #endregion
    }
}
