using Recruitment.Data.EntitiesService.CreateRepository;
using Recruitment.Data.EntitiesService.DeleteRepository;
using Recruitment.Data.EntitiesService.ReadRepository;
using Recruitment.Data.EntitiesService.UpdateRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Recruitment.Data.EntitiesService.Base
{
    public interface IBaseRepository<T> where T : class
    {
        #region Properties
        DbContext DbContext { get; set; }
        DbSet<T> DbSet { get; set; }
        #endregion
    }
}
