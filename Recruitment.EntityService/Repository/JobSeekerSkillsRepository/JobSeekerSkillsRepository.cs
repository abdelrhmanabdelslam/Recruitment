using Recruitment.Data.EntitiesService.Base;
using Microsoft.EntityFrameworkCore;
using Recruitment.Entity.Models;

namespace Recruitment.Data.EntitiesService.Repository
{
    public class JobSeekerSkillsRepository : BaseRepository<JobSeekerSkills>, IJobSeekerSkillsRepository
    {
        public JobSeekerSkillsRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}

