using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CompanyTypeRepository : BaseRepository<CompanyType>, ICompanyTypeRepository
    {
        public CompanyTypeRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

