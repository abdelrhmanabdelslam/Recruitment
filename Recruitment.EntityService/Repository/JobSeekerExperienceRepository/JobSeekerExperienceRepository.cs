using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerExperienceRepository : BaseRepository<JobSeekerExperience>, IJobSeekerExperienceRepository
    {
        public JobSeekerExperienceRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

