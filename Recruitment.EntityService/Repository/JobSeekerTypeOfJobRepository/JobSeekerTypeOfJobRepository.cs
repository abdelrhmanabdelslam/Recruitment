using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerTypeOfJobRepository : BaseRepository<JobSeekerTypeOfJob>, IJobSeekerTypeOfJobRepository
    {
        public JobSeekerTypeOfJobRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

