using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CompanySizeRepository : BaseRepository<CompanySize>, ICompanySizeRepository
    {
        public CompanySizeRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

