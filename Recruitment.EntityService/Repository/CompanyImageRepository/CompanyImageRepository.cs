using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CompanyImageRepository : BaseRepository<CompanyImage>, ICompanyImageRepository
    {
        public CompanyImageRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

