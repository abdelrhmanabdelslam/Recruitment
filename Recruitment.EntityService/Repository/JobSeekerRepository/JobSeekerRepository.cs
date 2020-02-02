using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerRepository : BaseRepository<JobSeeker>, IJobSeekerRepository
    {
        public JobSeekerRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

