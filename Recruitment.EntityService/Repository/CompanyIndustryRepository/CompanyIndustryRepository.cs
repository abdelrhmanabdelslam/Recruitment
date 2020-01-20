using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CompanyIndustryRepository : BaseRepository<CompanyIndustry>, ICompanyIndustryRepository
    {
        public CompanyIndustryRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

