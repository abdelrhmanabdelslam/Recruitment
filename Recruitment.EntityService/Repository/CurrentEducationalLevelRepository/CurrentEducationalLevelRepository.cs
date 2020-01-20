using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class CurrentEducationalLevelRepository : BaseRepository<CurrentEducationalLevel>, ICurrentEducationalLevelRepository
    {
        public CurrentEducationalLevelRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

