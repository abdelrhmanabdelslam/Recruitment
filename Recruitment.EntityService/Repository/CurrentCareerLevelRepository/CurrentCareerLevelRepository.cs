using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CurrentCareerLevelRepository : BaseRepository<CurrentCareerLevel>, ICurrentCareerLevelRepository
    {
        public CurrentCareerLevelRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

