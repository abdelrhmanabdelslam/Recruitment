using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerApplyStatusRepository : BaseRepository<JobSeekerApplyStatus>, IJobSeekerApplyStatusRepository
    {
        public JobSeekerApplyStatusRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

