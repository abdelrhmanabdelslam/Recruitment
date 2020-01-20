using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CompanyCoverImageRepository : BaseRepository<CompanyCoverImage>, ICompanyCoverImageRepository
    {
        public CompanyCoverImageRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

