using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class IndustryRepository : BaseRepository<Industry>, IIndustryRepository
    {
        public IndustryRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
